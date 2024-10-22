using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.PlayerClass;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    class TitleScreen : Scene
    {
        public TitleScreen(Game game) : base(game, ASCIIArt.titleArt) { }

        public override void Run()
        {
            Menu mainMenu = new Menu($"", $"{ASCIIArt.titleArt}", $"{ASCIIArt.mainMenuArt}", ["New Game", "About", "Credits", "Exit"]);

            //Menu.DisplayMainTitle();
            int selectedIndex = mainMenu.GetMenuChoice();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyPlayer.CharacterCreation();
                    break;
                case 1:
                    MyGame.AboutScreen.Run();
                    break;
                case 2:
                    MyGame.CreditsScreen.Run();
                    break;
                case 3:
                    MyGame.ExitScreen.Run();
                    break;
            };
        }
    }
}