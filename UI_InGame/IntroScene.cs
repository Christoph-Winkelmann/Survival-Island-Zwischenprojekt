using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_InGame
{
    internal class IntroScene : Scene
    {
        public IntroScene(Game game) : base(game, ASCIIArt.introArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{_artwork}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"
You awake at the shore of a deserted island. In order to survive you have to explore and gather food and resources.
Craft tools to help you with survival. Build parts of the raft and assemble them to escape this place.

Good Luck!
");
            ConsoleUtilities.WaitForKeyPress();
            MyGame.BeachScene.Run();
        }
    }
}
