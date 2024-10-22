using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    internal class ExitScreen : Scene
    {
        public ExitScreen(Game game) : base(game, ASCIIArt.exitArt)
        {
        }

        public override void Run()
        {
            Menu exitGameMenu = new Menu("", $"{ASCIIArt.exitArt}", "Are you sure?", ["Yes", "No"]);

            int selectedIndex = exitGameMenu.GetMenuChoice();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.EndScreen.Run();
                    break;
                case 1:
                    MyGame.TitleScreen.Run();
                    break;
            }
        }
    }
}
