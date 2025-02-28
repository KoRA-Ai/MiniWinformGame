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

        public BehaviorSystem(ResourceManager resourceManager, CharacterManager characterManager)
        {
            _resourceManager = resourceManager;
        }

        public BehaviorSystem(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public void EatFood(AllyCharacter character)
        {
            if (_resourceManager.TotalFoods >= character.Appetite)
            {
                character.EatFood();
                _resourceManager.EatFood(character.Appetite);
            }
        }

        public void GetBed(AllyCharacter character)
        {
            if (_resourceManager.EmptyBeds >= character.BedCount)
            {
                _resourceManager.AllocateBed(character.BedCount);
            }
        }

        /// <summary>
        /// 幾(turn)回合能作多少工作量(count)
        /// </summary>
        /// <param name="workType">工作類型</param>
        /// <param name="count">工作量</param>
        /// <param name="turn">回合數</param>
        public void Work(AllyCharacter character)
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

        public bool CanAllCharactersEat(List<AllyCharacter> inGameCharacters, ref StringBuilder errSb)
        {
            int exptectedMinFoodCount = 0;
            foreach (var ch in inGameCharacters)
            {
                exptectedMinFoodCount += ch.Appetite;
            }
            if (_resourceManager.TotalFoods >= exptectedMinFoodCount)
            {
                //eat
                foreach (var ch in inGameCharacters)
                {
                    EatFood(ch);
                }
                return true;
            }
            else
            {
                //remove character
                errSb.AppendLine("食物不夠");
                return false;
            }
        }

        public bool CanAllCharactersGetBed(List<AllyCharacter> inGameCharacters, ref StringBuilder errSb)
        {
            int exptectedMinBedCount = 0;
            foreach (var ch in inGameCharacters)
            {
                exptectedMinBedCount += ch.BedCount;
            }
            if (_resourceManager.EmptyBeds >= exptectedMinBedCount)
            {
                foreach (var ch in inGameCharacters)
                {
                    GetBed(ch);
                }
                return true;
            }
            else
            {
                //remove character
                errSb.AppendLine("床位不夠");
                return false;
            }
        }

        public void MakeAllCharactersWork(List<AllyCharacter> inGameCharacters)
        {
            foreach (var ch in inGameCharacters)
            {
                Work(ch);
            }
        }
    }
}