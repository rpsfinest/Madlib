using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_Madlib
{
    public class Program
    {
        public static void Main()
        {
            //run main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"        ,     \    /      ,        ");
            Console.WriteLine(@"       / \    )\__/(     / \       ");
            Console.WriteLine(@"      /   \  (_\  /_)   /   \      ");
            Console.WriteLine(@" ____/_____\__\@  @/___/_____\____ ");
            Console.WriteLine(@"|             |\../|              |");
            Console.WriteLine(@"|              \VV/               |");
            Console.WriteLine(@"|         A Dragon MadLib         |");
            Console.WriteLine(@"|_________________________________|");
            Console.WriteLine(@" |    /\ /      \\       \ /\    | ");
            Console.WriteLine(@" |  /   V        ))       V   \  | ");
            Console.WriteLine(@" |/     `       //        '     \| ");
            Console.WriteLine(@" `              V                ' ");

            bool rightChoice = true;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Please enter 1 or 2 for your selection".Length / 2)) + "}", "Please enter 1 or 2 for your selection"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("1.Start Game".Length / 2)) + "}", "1. Start Game"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("2. Exit".Length / 2)) + "}", "2.Exit"));    
            while (rightChoice)
            {
                rightChoice = false;
                string choice = (Console.ReadLine());


                switch (choice)
                {
                    case "1":
                        Madlib.Story();
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

/*playability, github and runs, split workload, multiple classes, funtioning UI
 * Menu
 * ask for varibles
 * return story including variables */