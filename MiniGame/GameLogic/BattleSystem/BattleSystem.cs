using Characters;
using GameLogic.Characters;
using GameLogic.Characters.EnemyCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameLogic.Characters.AllyCharacter;

namespace GameLogic.BattleSystem
{
    public class BattleSystem
    {
        private List<EnemyCharacter> _enemies;

        public BattleSystem(List<EnemyCharacter> enemies)
        {
            _enemies = enemies;
        }

        public BattleSystem(List<AllyCharacter> allies, int enemyCount)
        {
            _enemies = new List<EnemyCharacter>();
            for (int i = 1; i <= enemyCount; i++)
            {
                _enemies.Add(new Enemy01());
            }
        }

        public void Fight(List<AllyCharacter> allies)
        {
            Console.WriteLine("戰鬥開始");
            foreach (var ally in allies.Where(a => !a.IsDead).OrderByDescending(a => a.AttackPower).ThenByDescending(a => a.Appetite))
            {
                foreach (var enemy in _enemies.Where(e => !e.IsDead))
                {
                    if (ally.IsDead) continue;
                    Fight_1v1(ally, enemy);
                }
            }
        }

        public void Fight_1v1(AllyCharacter ally, EnemyCharacter enemy)
        {
            Console.WriteLine("【" + ally.AllyType.ToString() + " vs " + enemy.EnemyType.ToString() + "】");
            while (!ally.IsDead && !enemy.IsDead)
            {
                if (ally.AllyType == AllyTypes.Soldier && !ally.IsDead)
                {
                    enemy.TakeDamage(ally.AttackPower);
                }
                if (!enemy.IsDead && !ally.IsDead)
                {
                    ally.TakeDamage(enemy.AttackPower);
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        public int GetEnemyCount()
        {
            return _enemies.Count();
        }
    }
}