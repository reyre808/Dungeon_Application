using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Goblin : Monster
    {
        public bool IsHungry { get; set; }
        public Goblin(string name, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isHungry)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsHungry = isHungry;
        }

        public Goblin()
        {
            Name = "Gordo";
            MaxLife = 65;
            Life = 55;
            HitChance = 89;
            Block = 10;
            MinDamage = 30;
            MaxDamage = 40;
            IsHungry = true;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return base.ToString() + (IsHungry ? "\nHe looks hungry, Hes really fast!"
                : "\nHe looks slow");

        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsHungry)
            {
                calculatedBlock += calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}
