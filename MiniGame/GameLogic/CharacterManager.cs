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
        private List<AllyCharacter> _InGameCharacters;

        private List<AllyCharacter> InGameCharacters
        {
            get { return _InGameCharacters.Where(a => !a.IsDead).ToList(); }
            set
            {
                _InGameCharacters = value;
            }
        }

        public int MaxCharacterCount;
        private ResourceManager _resourceManager;
        private BehaviorSystem _behaviorSystem;

        public CharacterManager(GameConfiguration configuration, ResourceManager resourceManager)
        {
            this.MaxCharacterCount = configuration.MaxCharacterCount;
            _InGameCharacters = new List<AllyCharacter>();
            _resourceManager = resourceManager;
            _behaviorSystem = new BehaviorSystem(resourceManager);
        }

        #region 增減角色

        public (bool isSuccessed, string err) CheckHireRules(AllyCharacter character)
        {
            if (_InGameCharacters.Count >= MaxCharacterCount)
            {
                return (false, "超過場上人數上限");
            }

            int fee = character.Appetite * 2;//招募成本
            int bed = character.BedCount;

            if (_resourceManager.TotalFoods - fee < 0)
            {
                return (false, $"所需食物數量: {fee} -->食物不足");
            }

            if (_resourceManager.EmptyBeds - bed < 0)
            {
                return (false, $"所需床位數量: {bed} -->床位不足");
            }

            return (true, "驗鄭成功");
        }

        public void HireCharacter(AllyCharacter character, ref StringBuilder errMsg)
        {
            var result = CheckHireRules(character);
            if (result.isSuccessed)
            {
                _InGameCharacters.Add(character);
                bool eatOK = _behaviorSystem.EatFood(character, 2);
                bool bedOK = _behaviorSystem.GetBed(character);
                MaxCharacterCount++;
                errMsg.AppendLine("Add " + character.AllyType.ToString() + ", 剩餘食物: " + _resourceManager.TotalFoods);
            }
            else
            {
                errMsg.AppendLine(result.err);
            }
        }

        public (bool isSuccessed, string err) HireCharacter(AllyTypes allyType)
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
            var result = CheckHireRules(character);
            if (result.isSuccessed)
            {
                _InGameCharacters.Add(character);
                bool eatOK = _behaviorSystem.EatFood(character, 2);
                bool bedOK = _behaviorSystem.GetBed(character);
                MaxCharacterCount++;
            }
            return result;
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
                _InGameCharacters.Remove(character);
                MaxCharacterCount--;
                errMsg.AppendLine("移除" + character.AllyType.ToString());
            }
        }

        public void RemoveDeadCharacter(ref StringBuilder errmsg)
        {
            var deadCharacters = _InGameCharacters.Where(a => a.IsDead).ToList();
            foreach (var dead in deadCharacters)
            {
                RemoveCharacter(dead, ref errmsg);
                _InGameCharacters.Remove(dead);
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