using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Werewolf : Monster
    {
        public bool IsFullMoon { get; set; }
        public Werewolf(string name, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isFullMoon)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsFullMoon = isFullMoon;
        }

        public Werewolf()
        {
            Name = "Romeo";
            Life = 85;
            MaxLife = 95;
            HitChance = 65;
            Block = 25;
            MinDamage = 45;
            MaxDamage = 70;
            IsFullMoon = true;
        }
        public override string ToString()
        {
            return base.ToString() + (IsFullMoon ? "Uh oh its a full moon!!"
                : "He seems to be weakened");

        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsFullMoon)
            {
                calculatedBlock += calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}