using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_Madlib
{
    public static class Madlib
    {
        static public void Story()
        {
            //values requested from user
            Console.Clear();
            Console.WriteLine("Welcome to the Madlib, please type the required words!");

            Console.WriteLine("Type a Color:");
            string color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type a Superlative ending with est");
            string super = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type an Adjective");
            string adj1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type a Body Part (pluaral)");
            string bodyparts = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type a Body Part");
            string bodypart = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type a Noun");
            string noun = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type an Animal Plural");
            string animals = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type an Adjective");
            string adj2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type an Adjective");
            string adj3 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type an Adjective");
            string adj4 = Console.ReadLine();
            Console.Clear();

            //STORY WRITTEN using user's response
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The {color} Dragon is the {super} Dragon of all. It has {adj1} {bodyparts}, and a {bodypart} shaped like a {noun}. It loves to eat {animals}  , although it will feast on nearly anything. It is {adj2} and {adj3} . You must be {adj4} around it, or you may end up as it`s meal!");
            bool rightChoice = true;
            //loop for choice selection
            while (rightChoice)
            {
                rightChoice = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1.Return to Main Menu");
                Console.WriteLine("2.Exit the game");
                string choice =(Console.ReadLine());


                switch (choice)
                {
                    case "1":
                        Program.Main();
                        break;

                    case "2":
                        Leave.Exit();
                        break;

                    default:
                        Console.Write("Thats not a valid choice, please choose 1 or 2!\n");
                        rightChoice = true;
                        break;

                }
            }
        }
    }
}
