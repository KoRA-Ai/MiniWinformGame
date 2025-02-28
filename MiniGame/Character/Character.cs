using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public abstract class Character
    {
        public RoleType Role { get; protected set; }
        public int Appetite { get; protected set; }
        public int BedCount { get; protected set; }
        public int Hp { get; protected set; }
        public bool IsAlive { get; protected set; }

        public abstract void EatFood();

        public abstract void Work();
    }

    public enum RoleType
    {
        Farmer, Builder, Soldier
    }
}