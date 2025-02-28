using Characters;
using DataManagement;
using GameLogic.Characters;
using System;

namespace GameLogic.ResourceManagement
{
    public class ResourceManager
    {
        public int EmptyBeds;

        public int TotalFoods;

        public ResourceManager(GameConfiguration configuration)
        {
            TotalFoods = configuration.InitialFoodCount;
            EmptyBeds = configuration.InitialBedCount;
        }

        /// <summary>
        /// 幾(turn)回合能吃多少食物(decreaseCount)
        /// </summary>
        /// <param name="turn">回合數</param>
        public void EatFood(int decreaseCount, int turn = 1)
        {
            TotalFoods -= (decreaseCount / turn);
        }

        public void AllocateBed(int neededBedCount)
        {
            EmptyBeds -= neededBedCount;
        }

        public void MakeResource(AllyCharacter character)
        {
            character.Work();
        }

        /// <summary>
        /// 幾(turn)回合能作多少食物(addCount)
        /// 一回合工作量 = addCount / turn
        /// </summary>
        /// <param name="addCount">工作量</param>
        /// <param name="turn">回合數</param>
        public void MakeFood(int addCount, int turn = 1)
        {
            TotalFoods += (addCount / turn);
        }

        /// <summary>
        /// 幾(turn)回合能作多少床位(addCount)
        /// </summary>
        /// <param name="addCount">工作量</param>
        /// <param name="turn">回合數</param>
        public void MakeBed(int addCount, int turn = 1)
        {
            EmptyBeds += (addCount / turn);
            //TotalBeds += (addCount / turn);
        }

        public void GetCurrentResource()
        {
            Console.WriteLine("現在食物 :" + TotalFoods + "現在床位 :" + EmptyBeds);
        }

        public enum CheckResourceType
        {
            CheckBed, CheckFood, CheckAll
        }
    }
}