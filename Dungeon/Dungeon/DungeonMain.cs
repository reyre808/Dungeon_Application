﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class DungeonMain
    {
        static void Main(string[] args)
        {

            #region Introduction
            //Print a welcome.
            #endregion

            #region Create Player
            //TODO Create an instance of the player class.
            #endregion

            #region Gameplay loop

            #endregion

            #region Create Room and Monster
            //TODO: Print a random room description.
            //TODO: Create an instance of a Monster 
            #endregion



            private static string GetRoom()
            {
                //Requirements:
                /*
                 * 1. Create a collection of room descriptions
                 * 2.Randomly print one of those room descriptions to the console.
                 */
            }

            bool repeat = true;
            do
            {


            //TODO Create a Player
            Console.WriteLine("Welcome to the Dungeon!! ");
            Console.WriteLine("Please Enter Your Name and Hit Enter. ");
            

            Console.WriteLine("Hello " + Console.ReadLine() + " Are You Ready?");
            Console.WriteLine("Y) Yes\nN) No");
            string yesOrNo = Console.ReadLine().ToUpper();



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
                }
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
                                    repeat = !repeat;
                                    break;
                                }
                        } while (true);

            

                
            } while (repeat);

            //TODO Create A Monster

            //TODO Create A Room


        }//END MAIN
    }//END CLASS
}//END NAMESPACE


