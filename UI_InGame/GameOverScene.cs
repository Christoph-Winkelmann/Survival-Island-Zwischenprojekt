using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_InGame
{
    internal class GameOverScene : Scene
    {
        public GameOverScene(Game game) : base(game, ASCIIArt.gameOverArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{_artwork}");
            Console.WriteLine();
            Console.WriteLine("This is the end... Your food reserved are used up and you have no strength to carry on...\nBetter luck next time...");
            ConsoleUtilities.WaitForKeyPress();
            MyGame.EndScreen.Run();
        }
    }
}
