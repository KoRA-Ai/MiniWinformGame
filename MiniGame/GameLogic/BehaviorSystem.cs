using GameLogic.Characters;
using GameLogic.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Text;
using static GameLogic.Characters.Work;

namespace GameLogic
{
    public class BehaviorSystem//角色行為
    {
        private ResourceManager _resourceManager;

        public BehaviorSystem(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public bool EatFood(GoodCharacter character, int times = 1)
        {
            if (_resourceManager.TotalFoods >= character.Appetite * times)
            {
                character.EatFood();
                _resourceManager.EatFood(character.Appetite * times);
                return true;
            }
            else return false;
        }

        public bool GetBed(GoodCharacter character)
        {
            if (_resourceManager.EmptyBeds >= character.BedCount)
            {
                _resourceManager.AllocateBed(character.BedCount);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 幾(turn)回合能作多少工作量(count)
        /// </summary>
        /// <param name="workType">工作類型</param>
        /// <param name="count">工作量</param>
        /// <param name="turn">回合數</param>
        public void Work(GoodCharacter character)
        {
            foreach (var work in character.Works)
            {
                switch (work.workType)
                {
                    case WorkType.MakeFood:
                        character.Work();
                        _resourceManager.MakeFood(work.workload, work.turn);
                        break;

                    case WorkType.MakeBuilding:
                        character.Work();
                        _resourceManager.MakeBed(work.workload, work.turn);
                        break;

                    default:
                        throw new Exception("未實作WorkType");
                }
            }
        }

        public bool CanAllCharactersEat(List<GoodCharacter> inGameCharacters, ref StringBuilder errSb)
        {
            //先檢查是否需要移除角色，再進行消耗
            int exptectedMinFoodCount = 0;
            foreach (var ch in inGameCharacters)
            {
                exptectedMinFoodCount += ch.Appetite;
            }
            if (_resourceManager.TotalFoods >= exptectedMinFoodCount)
            {
                foreach (var ch in inGameCharacters)
                {
                    if (!EatFood(ch))
                    {
                        errSb.AppendLine("食物不夠");
                        return false;
                    }
                }
            }
            else
            {
                errSb.AppendLine("食物不夠");
                return false;
            }
            return true;
        }

        public bool CanAllCharactersGetBed(List<GoodCharacter> inGameCharacters, ref StringBuilder errSb)
        {
            //先檢查是否需要移除角色，再進行消耗
            int exptectedMinBedCount = 0;
            foreach (var ch in inGameCharacters)
            {
                exptectedMinBedCount += ch.BedCount;
            }
            //床位不用消耗，做檢查就好
            if (_resourceManager.TotalBeds < exptectedMinBedCount)
            {
                errSb.AppendLine("床位不夠");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakeAllCharactersWork(List<GoodCharacter> inGameCharacters)
        {
            foreach (var ch in inGameCharacters)
            {
                Work(ch);
            }
        }
    }
}