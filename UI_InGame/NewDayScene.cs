using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_InGame
{
    internal class NewDayScene : Scene
    {
        public NewDayScene(Game game) : base(game, ASCIIArt.sunriseArt)
        {
        }
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{_artwork}");
            Console.WriteLine($"{ASCIIArt.newDayArt}");
            ConsoleUtilities.WaitForKeyPress();
            Game.ActiveLocationList[0].Run();
        }

    }
}
