using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    internal class EndScreen : Scene
    {
        public EndScreen(Game game) : base(game, ASCIIArt.titleArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{ASCIIArt.titleArt}");
            Console.WriteLine("Thank you for playing! See you next time :)");
            ConsoleUtilities.WaitForKeyPress();
            ConsoleUtilities.QuitConsole();
        }
    }
}
