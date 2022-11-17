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

            bool isPlaying = true;
            bool isFighting = true;
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
            Goblin g1 = new Goblin();
            SpinedRat r1 = new SpinedRat();
            LizardMan l1 = new LizardMan();
            Werewolf w1 = new Werewolf();
           
            bool isInCombat = true;
            bool repeat = true;
            do
            {
                Console.WriteLine("");
                GetRoom();


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
                            Console.WriteLine("You Attacked The Monster\n\n" + " And Won!");
                            repeat = true;
                            break;

                        case "B":
                        case "RUN AWAY":
                        case "RUN":
                            Console.WriteLine("You Run Away From Battle\n\n");
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
                            break;

                        case "E":
                        case "EXIT":
                            Console.WriteLine("You Have Exited The Game, Thanks For Playing\n\n");
                            isInCombat = false;
                            repeat = false;
                            break;
                    }
                } while (isInCombat);

            } while (repeat);
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
                    Console.WriteLine("The moldy air fills the room, You feel the stagnant water seep through your shoes. You carefully step around what seems to be jagged " +
                        "rocks and cave slime");
                    break;
                case 2:
                    Console.WriteLine("The scorching sun is burning your skin as you fight your way through miles of sand and ancient ruins. Not a drop of water in sight.");
                    break;
                case 3:
                    Console.WriteLine("Heavy vegetation covers the forest, long tree vines block most of the pathways around the area.  You hear wild animals faintly in the distance ");
                    break;
                case 4:
                    Console.WriteLine("The floor feels hot to the step. The smell of sulfur and coal are almost overwhelming.  Seems like a bad place to light a match. ");
                    break;
                case 5:
                    Console.WriteLine("The air is calm, gravestones as far as you can see. Not the place you want to be at night. ");
                    break;
            }

            //TODO Create A Monster

            


            //TODO Create A Room


            //END MAIN
        }//END CLASS
        

    }
}//END NAMESPACE


