using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZwischenProjekt_CW
{
    static class ConsoleUtilities
    {
        public static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine();
            Write("(Press any key to continue... )");
            ReadKey(true);
        }

        public static void QuitConsole()
        {
            Clear();
            WriteLine("Exiting Console. Press any key to continue... ");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static void ClearConsoleLines(int numberOfLines)
        {
            ValueTuple< int, int > tuple1 = Console.GetCursorPosition();
            int currentRow = tuple1.Item2;

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                currentRow--;
                Console.SetCursorPosition(0, currentRow);
            }
            Console.WriteLine();
        }

        

    }
}
