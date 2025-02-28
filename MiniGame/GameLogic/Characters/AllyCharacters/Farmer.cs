using GameLogic.Characters;
using System.Collections.Generic;
using static GameLogic.Characters.Work;

namespace Characters
{
    public class Farmer : AllyCharacter
    {
        public Farmer()
        {
            this.AllyType = AllyTypes.Farmer;
            this.Appetite = 1;
            this.BedCount = 1;
            this.Hp = 10;
            this.AttackPower = 0;
            this.Works = new List<Work> {
                new Work(WorkType.MakeFood,3,1)
            };
        }

        public override void EatFood()
        {
            //吃飯
        }

        public override void Work()
        {
            //工作
        }
    }
}