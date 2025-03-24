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
        public List<EnemyCharacter> Enemies;

        public BattleSystem(List<EnemyCharacter> enemies)
        {
            Enemies = enemies;
        }

        public BattleSystem(int enemyCount)
        {
            Enemies = new List<EnemyCharacter>();
            for (int i = 1; i <= enemyCount; i++)
            {
                Enemies.Add(new Enemy01());
            }
        }

        public void Fight(List<AllyCharacter> allies, ref StringBuilder msg)
        {
            Console.WriteLine("戰鬥開始");
            foreach (var ally in allies.Where(a => !a.IsDead).OrderByDescending(a => a.AttackPower).ThenByDescending(a => a.Appetite))
            {
                foreach (var enemy in Enemies.Where(e => !e.IsDead))
                {
                    if (ally.IsDead) continue;
                    Fight_1v1(ally, enemy, ref msg);
                }
            }
        }

        public void Fight_1v1(AllyCharacter ally, EnemyCharacter enemy, ref StringBuilder msg)
        {
            Console.WriteLine("【" + ally.AllyType.ToString() + " vs " + enemy.EnemyType.ToString() + "】");
            while (!ally.IsDead && !enemy.IsDead)
            {
                if (ally.AttackPower > 0 && !ally.IsDead && !enemy.IsDead)
                {
                    enemy.TakeDamage(ally.AttackPower);
                    if (enemy.IsDead) { msg.AppendLine("敵人-1"); }
                }
                if (!enemy.IsDead && !ally.IsDead)
                {
                    ally.TakeDamage(enemy.AttackPower);
                    if (ally.IsDead) { msg.AppendLine(ally.AllyType.ToString() + " -1"); }
                }
            }
        }

        public int GetEnemyCount()
        {
            return Enemies.Where(a => !a.IsDead).Count();
        }
    }
}