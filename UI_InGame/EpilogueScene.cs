using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_InGame
{
    internal class EpilogueScene : Scene
    {
        public EpilogueScene(Game game) : base(game, ASCIIArt.winArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{_artwork}");
            Console.WriteLine($"{ASCIIArt.sunsetArt}");
            Console.WriteLine(@"
You put your raft into the water, waves playfully welcoming it. The food rations safely tugged on 
board you take a last look at the island that has almost become a home to you.
You avert your gaze and set sail. The wind is taking up, stretching the makeshift fabric of the sail. 
The raft is jolting up and slowly picking up speed.
Rudder in hands your new voyage begins. You sail into the sunset.
");
            ConsoleUtilities.WaitForKeyPress();
            MyGame.EndScreen.Run();
        }

    }
}
