using Characters;
using DataManagement;
using GameLogic.Characters;
using GameLogic.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static GameLogic.Characters.AllyCharacter;

namespace GameLogic
{
    public class CharacterManager//增減角色
    {
        private List<AllyCharacter> InGameCharacters;
        public int MaxCharacterCount;
        private ResourceManager _resourceManager;
        private BehaviorSystem _behaviorSystem;

        public CharacterManager(GameConfiguration configuration, ResourceManager resourceManager)
        {
            this.MaxCharacterCount = configuration.MaxCharacterCount;
            InGameCharacters = new List<AllyCharacter>();
            _resourceManager = resourceManager;
            _behaviorSystem = new BehaviorSystem(resourceManager);
        }

        #region 增減角色

        public bool CheckHireRules(List<AllyCharacter> characterList, out string output)
        {
            bool result = true;

            StringBuilder sb = new StringBuilder();
            bool isOverLimit = false;
            if (characterList.Count >= MaxCharacterCount)
            {
                sb.AppendLine(" 超過場上人數上限");
                isOverLimit = true;
            }

            int fee = 0;
            int bed = 0;
            foreach (var ch in characterList)
            {
                fee += ch.Appetite * 2;//招募成本
                bed += ch.BedCount; ;
            }
            bool isEnoughFood = (_resourceManager.TotalFoods - fee >= 0 ? true : false);
            sb.AppendLine($"所需食物數量: {fee}" + (isEnoughFood ? "" : "-->食物不足"));

            bool isEnoughBed = (_resourceManager.EmptyBeds - bed >= 0 ? true : false);
            sb.AppendLine($"所需床位數量: {bed}" + (isEnoughBed ? "" : "-->床位不足"));

            result = !isOverLimit && isEnoughFood && isEnoughBed;

            output = sb.ToString();
            return result;
        }

        public void HireCharacter(AllyCharacter character, ref StringBuilder errMsg)
        {
            int fee = character.Appetite * 2;//招募成本

            if (InGameCharacters.Count <= MaxCharacterCount)
            {
                if (_resourceManager.TotalFoods - fee >= 0)
                {
                    InGameCharacters.Add(character);
                    _resourceManager.EatFood(fee);
                    MaxCharacterCount++;
                    errMsg.AppendLine("Add " + character.AllyType.ToString() + ", 剩餘食物: " + _resourceManager.TotalFoods);
                }
                else
                {
                    //食物不足
                    errMsg.AppendLine(character.AllyType.ToString() + "角色加入失敗 - 食物不足");
                }
            }
            else
            {
                //超過場上人數上限
                errMsg.AppendLine(character.AllyType.ToString() + "角色加入失敗 - 超過場上人數上限");
            }
        }

        public void HireCharacter(AllyTypes allyType, ref StringBuilder errMsg)
        {
            AllyCharacter character;
            switch (allyType)
            {
                case AllyTypes.Farmer:
                    character = new Farmer();
                    break;

                case AllyTypes.Builder:
                    character = new Builder();
                    break;

                case AllyTypes.Soldier:
                    character = new Soldier();
                    break;

                default:
                    throw new ArgumentNullException();
            }

            int fee = character.Appetite * 2;//招募成本

            if (InGameCharacters.Count <= MaxCharacterCount)
            {
                if (_resourceManager.TotalFoods - fee >= 0)
                {
                    InGameCharacters.Add(character);
                    _resourceManager.EatFood(fee);
                    MaxCharacterCount++;
                    errMsg.AppendLine("Add " + character.AllyType.ToString() + ", 剩餘食物: " + _resourceManager.TotalFoods);
                }
                else
                {
                    //食物不足
                    errMsg.AppendLine(character.AllyType.ToString() + "角色加入失敗 - 食物不足");
                }
            }
            else
            {
                //超過場上人數上限
                errMsg.AppendLine(character.AllyType.ToString() + "角色加入失敗 - 超過場上人數上限");
            }
        }

        public void AutoRemoveCharacter(ResourceManager.CheckResourceType checkResourceType, ref StringBuilder errMsg)
        {
            if (checkResourceType == ResourceManager.CheckResourceType.CheckFood)
            {
                RemoveCharacter_Food(ref errMsg);
            }
            else if (checkResourceType == ResourceManager.CheckResourceType.CheckBed)
            {
                RemoveCharacter_Bed(ref errMsg);
            }
            else if (checkResourceType == ResourceManager.CheckResourceType.CheckAll)
            {
                RemoveCharacter_Food(ref errMsg);
                RemoveCharacter_Bed(ref errMsg);
            }
        }

        public void RemoveCharacter_Food(ref StringBuilder errMsg)
        {
            //根據食量大小移除角色
            var list = InGameCharacters.OrderByDescending(c => c.Appetite);
            if (list.Count() > 0)
                RemoveCharacter(list.First(), ref errMsg);
        }

        public void RemoveCharacter_Bed(ref StringBuilder errMsg)
        {
            //裁減 農夫→建築師→士兵
            if (GetFarmersCount() != 0)
            {
                RemoveCharacter(InGameCharacters.Where(c => c.AllyType == AllyTypes.Farmer).First(), ref errMsg);
            }
            else if (GetBuildersCount() != 0)
            {
                RemoveCharacter(InGameCharacters.Where(c => c.AllyType == AllyTypes.Builder).First(), ref errMsg);
            }
            else if (GetSoldiersCount() != 0)
            {
                RemoveCharacter(InGameCharacters.Where(c => c.AllyType == AllyTypes.Soldier).First(), ref errMsg);
            }
        }

        public void RemoveCharacter(AllyCharacter character, ref StringBuilder errMsg)
        {
            bool canRemove = true;
            switch (character.AllyType)
            {
                case AllyTypes.Farmer:
                    if (GetFarmersCount() == 0)
                    {
                        errMsg.AppendLine("場上已無Farmer 可移除");
                        canRemove = false;
                    }
                    break;

                case AllyTypes.Builder:
                    if (GetBuildersCount() == 0)
                    {
                        errMsg.AppendLine("場上已無Builder 可移除");
                        canRemove = false;
                    }
                    break;

                case AllyTypes.Soldier:
                    if (GetSoldiersCount() == 0)
                    {
                        errMsg.AppendLine("場上已無Soldier 可移除");
                        canRemove = false;
                    }
                    break;
            }
            if (canRemove)
            {
                InGameCharacters.Remove(character);
                MaxCharacterCount--;
                errMsg.AppendLine("移除" + character.AllyType.ToString());
            }
        }

        public void RemoveDeadCharacter(ref StringBuilder errmsg)
        {
            //InGameCharacters = InGameCharacters.Where(a => !a.IsDead).ToList();

            var deadCharacters = InGameCharacters.Where(a => a.IsDead).ToList();
            foreach (var dead in deadCharacters)
            {
                RemoveCharacter(dead, ref errmsg);
                InGameCharacters.Remove(dead);
                _resourceManager.EmptyBeds++;
            }
        }

        #endregion 增減角色

        #region 角色行為

        public void MakeAllCharactersWork(ref StringBuilder errSb)
        {
            _behaviorSystem.MakeAllCharactersWork(InGameCharacters);
            errSb.AppendLine("工作完了" + ", 剩餘食物: " + _resourceManager.TotalFoods + ", 剩餘床位: " + _resourceManager.EmptyBeds);
        }

        public void AllocateResourceAndRemoveCharacter(ref StringBuilder errSb)
        {
            AllocateCharacterMeals(ref errSb);
            AllocateCharacterHousing(ref errSb);
        }

        public void AllocateCharacterMeals(ref StringBuilder errSb)
        {
            while (!_behaviorSystem.CanAllCharactersEat(InGameCharacters, ref errSb))
            {
                RemoveCharacter_Food(ref errSb);
            }
            errSb.AppendLine("已分配完食物" + ", 剩餘食物: " + _resourceManager.TotalFoods);
        }

        public void AllocateCharacterHousing(ref StringBuilder errSb)
        {
            while (!_behaviorSystem.CanAllCharactersGetBed(InGameCharacters, ref errSb))
            {
                RemoveCharacter_Bed(ref errSb);
            }
            errSb.AppendLine("已分配完床位" + ", 剩餘床位: " + _resourceManager.EmptyBeds);
        }

        #endregion 角色行為

        public List<AllyCharacter> GetAllInGameCharacters()
        {
            return InGameCharacters;
        }

        public int GetAllCharactersCount()
        {
            return InGameCharacters.Count();
        }

        public int GetFarmersCount()
        {
            return InGameCharacters.Where(a => a.AllyType == AllyTypes.Farmer).Count();
        }

        public int GetBuildersCount()
        {
            return InGameCharacters.Where(a => a.AllyType == AllyTypes.Builder).Count();
        }

        public int GetSoldiersCount()
        {
            return InGameCharacters.Where(a => a.AllyType == AllyTypes.Soldier).Count();
        }

        public void GetCurrentCharacterStatus()
        {
            Console.WriteLine("場上人數:");
            Console.WriteLine("Farmer  :" + GetFarmersCount());
            Console.WriteLine("Builder :" + GetBuildersCount());
            Console.WriteLine("Soldier :" + GetSoldiersCount());
        }
    }
}