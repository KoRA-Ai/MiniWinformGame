using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public abstract class BaseCharacter
    {
        public CharacterTypes CharacterType { get; protected set; }
        private int _hp;

        public int Hp
        {
            get
            {
                if (_hp < 0) return 0;
                else return _hp;
            }
            protected set { if (value < 0) _hp = 0;else _hp = value; }
        }

        public bool IsDead { get { if (Hp <= 0) return true; else return false; } }
        public int AttackPower { get; protected set; }

        public BaseCharacter(CharacterTypes type)
        {
            this.CharacterType = type;
        }

        public virtual void TakeDamage(int damage)
        {
            this.Hp -= damage;
        }

        public enum CharacterTypes
        {
            character, Enemy
        }
    }
}