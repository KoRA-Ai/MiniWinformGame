using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Characters
{
    public abstract class GoodCharacter : BaseCharacter
    {
        public PositionTypes PositionType { get; protected set; }
        public int Appetite { get; protected set; }
        public int BedCount { get; protected set; }
        public List<Work> Works { get; protected set; }

        public GoodCharacter() : base(CharacterTypes.Ally)
        {
        }

        public abstract void EatFood();

        public abstract void Work();

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine(this.PositionType.ToString() + "受傷害 -" + damage + " HP: " + this.Hp);
        }

        public enum PositionTypes
        {
            Farmer, Builder, Soldier
        }
    }

    public class Work
    {
        public WorkType workType;
        public int workload;
        public int turn;

        public Work(WorkType workType, int workload, int turn)
        {
            this.workType = workType;
            this.workload = workload;
            this.turn = turn;
        }

        public enum WorkType
        {
            MakeFood, MakeBuilding//, Fight
        }
    }
}