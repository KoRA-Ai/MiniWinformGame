using GameLogic.Characters;
using System.Collections.Generic;
using static GameLogic.Characters.Work;

namespace Characters
{
    public class Soldier : AllyCharacter
    {
        public Soldier()
        {
            this.AllyType = AllyTypes.Soldier;
            this.Appetite = 3;
            this.BedCount = 1;
            this.Hp = 50;
            this.AttackPower = 20;
            this.Works = new List<Work>
            {
                //new Work(WorkType.Fight,1,1)
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