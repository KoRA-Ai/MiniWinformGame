using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class GameConfiguration
    {
        public int InitialEnemyCount = 10;
        public int InitialFoodCount = 20;
        public int InitialBedCount = 20;
        public int MaxCharacterCount = 20;

        public GameConfiguration(int enemyCount, int foodCount, int bedCount, int maxCharCount)
        {
            InitialEnemyCount = enemyCount;
            InitialFoodCount = foodCount;
            InitialBedCount = bedCount;
            MaxCharacterCount = maxCharCount;
        }

        public void SetEnemyCount(int count)
        {
            InitialEnemyCount = count;
        }

        public void SetDefaultFoodCount(int count)
        {
            InitialFoodCount = count;
        }

        public void SetDefaultBedCount(int count)
        {
            InitialBedCount = count;
        }

        public void SetMaxCharacterCount(int count)
        {
            MaxCharacterCount = count;
        }
    }
}