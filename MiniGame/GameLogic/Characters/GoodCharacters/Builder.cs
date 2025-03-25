using GameLogic.Characters;
using System.Collections.Generic;
using static GameLogic.Characters.Work;

namespace Characters
{
    public class Builder : GoodCharacter
    {
        public Builder()
        {
            this.PositionType = PositionTypes.Builder;
            this.Appetite = 2;
            this.BedCount = 1;
            this.Hp = 10;
            this.AttackPower = 0;
            this.Works = new List<Work> {
                new Work(WorkType.MakeBuilding,2,1)
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