using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//ADDED for easier access to Thread.Sleep(). line 29
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //This is NOT a datatype class, so we will not have any
        //fields, properties, or constructors. It will simply server
        //as a 'warehouse' of methods related to combat.

        public static void DoAttack(Character attacker, Character defender) 
        {
            //Get a random number from 1-100
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            //Nothing is TRULY random in programming, but suspending
            //the code execution briefly may help simulate the 
            //'randomness' of the roll.

            //Thread.Sleep() in the System.Threading namespace
            //will provide this brief pause.

            Thread.Sleep(2000);

            //If the attacker "hits"
            if(roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculate the damage
                int damageDealt = attacker.CalcDamage();

                //subtract that damage from the defenders life
                defender.Life -= damageDealt;

                //Print the result in red:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} Hit for {2} damage!\n",
                    attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} Missed!\n", attacker.Name);
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            Thread.Sleep(2000);

            //If the monster survives the player's attack,
            //They attack the player.
            if(monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}
