using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_Madlib
{
    public static class Leave
    {
        static public void Exit()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Thanks for playing!".Length / 2)) + "}", "Thanks for playing!"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Made by Prabal and William.".Length / 2)) + "}", "Made by Prabal and William."));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"                 /           /     ");
            Console.WriteLine(@"                /' .,,,,  ./       ");
            Console.WriteLine(@"               /';'     ,/         ");
            Console.WriteLine(@"              / /   ,,//,`'`       ");
            Console.WriteLine(@"             ( ,, '_,  ,,,' ``     ");
            Console.WriteLine(@"             |    /@  ,,, ;"      );
            Console.WriteLine(@"            /    .   ,''/' `,``     ");
            Console.WriteLine(@"           /   .     ./, `,, ` ;   ");
            Console.WriteLine(@"        ,./  .   ,-,',` ,,/''\,'   ");
            Console.WriteLine(@"       |   /; ./,,'`,,'' |   |     ");
            Console.WriteLine(@"       |     /   ','    /    |     ");
            Console.WriteLine(@"        \___/'   '     |     |      ");
            Console.WriteLine(@"          `,,'  |      /     `\      ");
            Console.WriteLine(@"Art by         /      |        ~\    ");
            Console.WriteLine(@" Prabal       '       (               ");
            Console.WriteLine(@"             :                       ");
            Console.WriteLine(@"            ; .         \--          ");
            Console.WriteLine(@"          :   \         ;");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();


        }
    }
}
