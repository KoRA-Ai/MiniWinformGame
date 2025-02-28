using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Farmer : Character
    {
        private int MakeFoodCount = 3;

        public Farmer()
        {
            this.Role = RoleType.Builder;
            this.Appetite = 1;
            this.BedCount = 1;
            this.Hp = 10;
            this.IsAlive = true;
        }

        public override void EatFood()
        {
            throw new NotImplementedException();
        }

        public override void Work()
        {
        }
    }
}