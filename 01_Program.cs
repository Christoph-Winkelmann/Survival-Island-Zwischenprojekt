using System.Reflection;
using static System.Console;

namespace ZwischenProjekt_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Survival Island";
            CursorVisible = false;

            try
            {
                WindowWidth = 240;
                WindowHeight = 60;
            }
            catch
            {
                WriteLine("Could not set the intended window size.\nTry adjusting your font/console settings and restart.");
                WriteLine("You can continue playing, but be aware that some art might not render properly.");
                ConsoleUtilities.WaitForKeyPress();
            }

            Game newGame = new Game();
            newGame.Start();


        }
    }
}
