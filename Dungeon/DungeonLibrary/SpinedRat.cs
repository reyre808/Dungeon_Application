using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class SpinedRat : Monster
    {
        public bool IsDiseased { get; set; }
        public SpinedRat(string name, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isDiseased)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsDiseased = isDiseased;
        }

        public SpinedRat()
        {
            Name = "Pinky";
            MaxLife = 45;
            Life = 35;
            HitChance = 50;
            Block = 0;
            MinDamage = 10;
            MaxDamage = 30;
            IsDiseased = true;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return base.ToString() + (IsDiseased ? "\nHe looks sick , better not let him bite me"
                : "\nJust a normal mean rat");

        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsDiseased)
            {
                calculatedBlock += calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}

