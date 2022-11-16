using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    
    
        public class Rabbit : Monster
        {
            public bool IsFluffy { get; set; }

            public Rabbit(string name, int life, int maxLife, int hitChance, int block,
                int minDamage, int maxDamage, bool isFluffy)
                : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
            {
                IsFluffy = isFluffy;
            }

            public override string ToString()
            {
                return base.ToString() + (IsFluffy ? "It;s so fluffy, I'm gonna die!"
                    : "Not so flyffy...");
            }

            public override int CalcBlock()
            {
                int calculatedBlock = Block;
                if (IsFluffy)
                {
                    calculatedBlock += calculatedBlock / 2;
                }
                return calculatedBlock;
            }
        }
}

