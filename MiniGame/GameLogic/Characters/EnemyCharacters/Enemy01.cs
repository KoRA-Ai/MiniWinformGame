using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Characters.EnemyCharacters
{
    internal class Enemy01 : EnemyCharacter
    {
        public Enemy01()
        {
            this.EnemyType = EnemyTypes.Enemy01;
            this.Hp = 40;
            this.AttackPower = 20;
        }
    }
}