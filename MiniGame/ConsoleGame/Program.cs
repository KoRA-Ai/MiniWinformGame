using Characters;
using DataManagement;
using GameLogic;
using GameLogic.BattleSystem;
using GameLogic.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameConfiguration initConfiguration = new GameConfiguration(5, 200, 5, 5);
            ResourceManager resourceManager = new ResourceManager(initConfiguration);
            //BehaviorSystem behaviorSystem = new GameLogic.BehaviorSystem(resourceManager, characterManager);
            CharacterManager characterManager = new CharacterManager(initConfiguration, resourceManager);
            BattleSystem battaleSystem = new BattleSystem(initConfiguration.InitialEnemyCount);

            Console.WriteLine("食物數量: " + initConfiguration.InitialFoodCount);
            Console.WriteLine("床位數量: " + initConfiguration.InitialBedCount);
            Console.WriteLine("敵人數量: " + initConfiguration.InitialEnemyCount);
            //! 招募
            StringBuilder part1Msg = new StringBuilder();
            characterManager.HireCharacter(new Builder(), ref part1Msg);
            characterManager.HireCharacter(new Builder(), ref part1Msg);
            characterManager.HireCharacter(new Farmer(), ref part1Msg);
            characterManager.HireCharacter(new Farmer(), ref part1Msg);
            characterManager.HireCharacter(new Soldier(), ref part1Msg);
            //characterManager.HireCharacter(new Soldier(), ref part1Msg);

            //characterManager.HireCharacter(new Farmer(), ref part1Msg);
            Console.WriteLine(part1Msg);

            //! 分配資源
            StringBuilder part2Msg = new StringBuilder();
            characterManager.AllocateResourceAndRemoveCharacter(ref part2Msg);
            Console.WriteLine(part2Msg);

            //! 戰鬥
            StringBuilder part3Msg = new StringBuilder();
            battaleSystem.Fight(characterManager.GetAllInGameCharacters());
            characterManager.RemoveDeadCharacter(ref part3Msg);
            Console.WriteLine(part3Msg);

            //debug
            //統計數量
            characterManager.GetCurrentCharacterStatus();
            resourceManager.GetCurrentResource();

            StringBuilder part4Msg = new StringBuilder();
            //! 產資源
            characterManager.MakeAllCharactersWork(ref part4Msg);
            Console.WriteLine(part4Msg);
            Console.ReadKey();
        }
    }
}