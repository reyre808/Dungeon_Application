using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {
        public bool IsShiny { get; set; }
        public DateTime HourChangeBack { get; set; }
        public Vampire(string name, string description, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isShiny, DateTime hourChangeBack)
            : base(name, description, hitChance, block, life, maxLife, minDamage, maxDamage)
        {
            HourChangeBack = DateTime.Now;

            if(HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MaxDamage += 5;
                MinDamage += 5;

            }

        }

        public Vampire()
        {
            Name = "Eddy";
            Life = 60;
            MaxLife = 70;
            HitChance = 90;
            Block = 0;
            MinDamage = 20;
            MaxDamage = 30;
            IsShiny = true;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("{0}",
                HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ?
                "Empowered by the night!" : "Weakened by the daylight"
                ) + String.Format("\n{0}",
                IsShiny ? "He's sparkling. how beatiful!" : ""
                );
        }




    }

}

