using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonLibrary
{
    public class Player : Character//Inheritance syntax: Child Class : Parent Class
    {
        //FIELDS
        //_life is inherited from Character.

        //PROPS
        //Name, HitChance, Block, Life, and MaxLife are inherited from Character.
        //UNIQUE properties of Player:
        public PlayerRace Race { get; set; }
        public Weapons EquippedWeapon { get; set; }

        //CONSTRUCTOR
        //We need to take in all the properties as parameters,
        //EVEN the ones that were inherited from Character.
        public Player(string name, int hitChance, int block, int life, int maxLife, PlayerRace race, Weapons equippedWeapon) : base (name, hitChance, block, life, maxLife)
        {
            Race = race;
            EquippedWeapon = equippedWeapon;


        }

        //METHODS
        public override string ToString()
        {
            string raceDescription = "";

            switch (Race)
            {
                case PlayerRace.Human:
                    raceDescription = "Just an average everyday normal guy";
                    break;
                case PlayerRace.Barbarian:
                    raceDescription = "Rugged, war ready specimen";
                    break;
                case PlayerRace.Wizard:
                    raceDescription = "A 1000 year old Master of the Magic";
                    break;
                case PlayerRace.Elf:
                    raceDescription = "A highly intelligent race with magical powers and super speed";
                    break;
                case PlayerRace.Dwarf:
                    raceDescription = "A Small warrior with a big heart";
                    break;

            }

            return base.ToString() + "\nDescription : " + raceDescription + "\nWeapon : " + EquippedWeapon;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(
                EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage +1
                );

            return damage;
        }

        public override int CalcHitChance()
        {
        return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
