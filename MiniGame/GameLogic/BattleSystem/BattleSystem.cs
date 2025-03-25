using Characters;
using GameLogic.Characters;
using GameLogic.Characters.EnemyCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameLogic.Characters.GoodCharacter;

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

        public void Fight(List<GoodCharacter> characters, ref StringBuilder msg)
        {
            Console.WriteLine("戰鬥開始");
            int aIndex = 1;
            int eIndex = 0;
            foreach (var character in characters.Where(a => !a.IsDead).OrderByDescending(a => a.AttackPower).ThenByDescending(a => a.Appetite))
            {
                foreach (var enemy in Enemies.Where(e => !e.IsDead))
                {
                    if (character.IsDead) continue;
                    msg.AppendLine("【" + character.PositionType.ToString() + aIndex + " vs " + enemy.EnemyType.ToString() + eIndex + "】");
                    Fight_1v1(character, enemy, ref msg);

                    eIndex++;
                }
                aIndex++;
            }
        }

        public void Fight_1v1(GoodCharacter character, EnemyCharacter enemy, ref StringBuilder msg)
        {
            while (!character.IsDead && !enemy.IsDead)
            {
                //如果角色打死一個人就不能再打架了
                if (character.AttackPower > 0 && !character.IsDead && !enemy.IsDead && character.CanAttack)
                {
                    enemy.TakeDamage(character.AttackPower);
                    if (enemy.IsDead)
                    {
                        msg.AppendLine("敵人-1");
                        character.CanAttack = false;
                    }
                }
                if (!enemy.IsDead && !character.IsDead)
                {
                    character.TakeDamage(enemy.AttackPower);
                    if (character.IsDead) { msg.AppendLine(character.PositionType.ToString() + " -1"); }
                }
            }
        }

        public int GetEnemyCount()
        {
            return Enemies.Where(a => !a.IsDead).Count();
        }
    }
}