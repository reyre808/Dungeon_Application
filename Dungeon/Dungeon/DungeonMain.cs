using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;



namespace Dungeon
{
    internal class DungeonMain
    {
        static void Main(string[] args)
        {

            #region Introduction
            //Print a welcome.
            #endregion
            int score = 0;


            //TODO Create a Player
            Console.WriteLine("Welcome to the Dungeon!! ");
            Console.WriteLine("Please Enter Your Name and Hit Enter. ");


            Console.WriteLine("Hello " + Console.ReadLine() + " Are You Ready?");
            Console.WriteLine("Y) Yes\nN) No");
            string yesOrNo = Console.ReadLine().ToUpper();

            string playerName = Console.ReadLine();

            switch (yesOrNo)
            {
                case "YES":
                case "Y":
                    Console.WriteLine("Okay As You Wish, Lets Get Started");
                    break;

                case "NO":
                case "N":
                    Console.WriteLine("Come Back When You Have Some Heart And Honor");
                    break;
                    bool notReady = false;
            }
           
            /* Bonus : Customizing the weapons.
             * 1) Construct custom weapon objects.
             */
             
            Weapons sword1 = new Weapons(30, 55, "Long Sword", 15, true, WeaponType.Melee);
            Weapons sword2 = new Weapons(15, 45, "Sword", 15, true, WeaponType.Melee);
            Weapons sword3 = new Weapons(35, 65, "Battle Axe", 15, true, WeaponType.Melee);

            // Counter
            bool playerIsChoosingWeapon = true;

            Weapons chosenWeapon;

            Player player = new Player(playerName, 70, 5, 100, 100, PlayerRace.Human, sword1);

            do
            {
                Console.WriteLine("\nChoose your weapon:\n" +
                    "(L) Long Sword\n" +
                    "(S) Sword\n" +
                    "(B) Battle Axe\n");

                ConsoleKey userKey = Console.ReadKey().Key;

                switch (userKey)
                {
                    case ConsoleKey.L:
                        chosenWeapon = sword1;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.S:
                        chosenWeapon = sword2;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.B:
                        chosenWeapon = sword3;
                        playerIsChoosingWeapon = false;
                        break;
                    default:
                        Console.WriteLine("Input invalid . Please press (S) , (L) , or (A).");
                        break;
                }


            } while (playerIsChoosingWeapon);

            bool playerIsChoosingRace = true;
            do
            {
            Console.Clear();
            Console.WriteLine("\nChoose a Race:" +
                "\n(H) Human" +
                "\n(D) Donkey" +
                "\n(A) Alien");

            ConsoleKey raceChoice = Console.ReadKey().Key;

                switch (raceChoice)
                {
                    case ConsoleKey.H:
                        player.Race = PlayerRace.Human;
                        playerIsChoosingRace=false;
                        break;
                    case ConsoleKey.D:
                        player.Race = PlayerRace.Donkey;
                        playerIsChoosingRace = false;
                        break;
                    case ConsoleKey.A:
                        player.Race = PlayerRace.Alien;
                        playerIsChoosingRace = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, Please Press (H) , (D) , or (A).");
                        break;
                }

            } while (playerIsChoosingRace);








            bool playerIsAlive = true;
            bool playerIsFighting = true;
            
            do
            {
                Console.WriteLine("");
                GetRoom();

            Goblin g1 = new Goblin();
            SpinedRat r1 = new SpinedRat();
            LizardMan l1 = new LizardMan();
            Werewolf w1 = new Werewolf();

            Monster[] monsters =
            {
                g1,
                r1,
                l1,
                w1
            };
            Random rand = new Random();
            int randomNbr = rand.Next(monsters.Length);
            Monster monster = monsters[randomNbr];

            Console.WriteLine("You run into a {0}!", monster.Name);

                //TODO Create a Player


                do
                {

                    Console.WriteLine("Interaction Menu");
                    Console.WriteLine("A) Attack\nB) Run Away\nC) Character Info\nD) Monster Info\nE) Exit");
                    string playerChoice = Console.ReadLine().ToUpper();

                    Console.Clear();

                    switch (playerChoice)
                    {
                        case "A":
                        case "ATTACK":
                        case "ATT":

                            Combat.DoBattle(player, monster);

                            //Check Monster Health
                            if(monster.Life <= 0)
                            {
                                //Use green text to highlight winning combat:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}", monster.Name);
                                Console.ResetColor();

                                score++;

                                //end this combat loop
                                playerIsFighting = false;
                            }
                            playerIsFighting = true;
                            break;

                        case "B":
                        case "RUN AWAY":
                        case "RUN":
                            Console.WriteLine("You Run Away From Battle\n\n");

                            //Give monster an attack of opportunity when the player attempts to run away:
                            Console.WriteLine($"{monster.Name} attacks you as you run away!");
                            Combat.DoAttack(monster, player);

                            playerIsFighting = false;
                            break;

                        case "C":
                        case "CHARACTER INFO":
                        case "CHARACTER":
                            Console.WriteLine("You Display Your Character Info\n\n");
                            break;

                        case "D":
                        case "MONSTER INFO":
                        case "MONSTER":
                        case "M":
                            Console.WriteLine("You Display The Monster's Info\n\n");
                            playerIsFighting=true;
                            break;

                        case "E":
                        case "EXIT":
                            Console.WriteLine("You Have Exited The Game, Thanks For Playing\n\n");
                            playerIsFighting = false;
                            playerIsAlive = false;
                            break;
                    }

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Game Over");
                        playerIsFighting = false;
                        playerIsAlive = false;
                    }
                } while (playerIsFighting);

            } while (playerIsAlive);
        }
        public static void GetRoom()
        {

            //Requirements:
            /*
             * 1. Create a collection of room descriptions
             * 2.Randomly print one of those room descriptions to the console.
             */

            Console.WriteLine("Starting Your Adventure");
            Console.WriteLine();


            Console.WriteLine();
            int random = 0;
            Random randomRoom = new Random();
            random = randomRoom.Next(1, 6);

            switch (random)
            {
                case 1:
                    Console.WriteLine("The moldy air fills the room, You feel the stagnant water seep through your shoes.\n You carefully step around what seems to be jagged " +
                        "rocks and cave slime ");
                    break;
                case 2:
                    Console.WriteLine("The scorching sun is burning your skin as you fight your way through miles of sand and ancient ruins.\n Not a drop of water in sight.");
                    break;
                case 3:
                    Console.WriteLine("Heavy vegetation covers the forest, long tree vines block most of the pathways around the area.  \nYou hear wild animals faintly in the distance ");
                    break;
                case 4:
                    Console.WriteLine("The floor feels hot to the step. The smell of sulfur and coal are almost overwhelming. \n Seems like a bad place to light a match. ");
                    break;
                case 5:
                    Console.WriteLine("The air is calm, gravestones as far as you can see. \nNot the place you want to be at night. ");
                    break;
            }

            //TODO Create A Monster

            


            //TODO Create A Room


            //END MAIN
        }//END CLASS
        

    }
}//END NAMESPACE


