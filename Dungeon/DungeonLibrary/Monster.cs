using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        private int _minDamage;
        
        //PROPS

        public int MinDamage {
            get { return _minDamage; }
            set { 
                if (value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = MaxDamage;
                }
            }
        }
        public int MaxDamage { get; set; }

        string monsterDescription = "";


        public Monster()
        {

        }

        public Monster(string name, int hitChance, int block, int life, int maxLife, int maxDamage, int minDamage)
            : base (name,hitChance, block, life, maxLife)
        {
            
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} - {MaxDamage}";
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(
                MinDamage,
                MaxDamage + 1
                );

            return damage;
        }
         




    }
}
