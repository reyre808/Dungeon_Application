using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapons
    {
        public int MinDamage { get; set; }
        


        
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public WeaponType Type { get; set; }

        public Weapons(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }

        public override string ToString()
        {
            return "Mininmal Damage" + MinDamage + "Maximum Damage" + MaxDamage + "Name" + Name + "Bonus Hit Chance" + BonusHitChance + "Is Two Handed" + IsTwoHanded + "Type" + Type;
        }

    }
}
