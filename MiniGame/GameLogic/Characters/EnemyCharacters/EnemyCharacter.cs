using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Characters.EnemyCharacters
{
    public abstract class EnemyCharacter : BaseCharacter
    {
        public EnemyTypes EnemyType { get; protected set; }

        public EnemyCharacter() : base(CharacterTypes.Enemy)
        {
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine(this.EnemyType.ToString() + "受傷害 -" + damage + " HP: " + this.Hp);
        }

        public enum EnemyTypes
        {
            Enemy01
        }
    }
}