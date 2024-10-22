using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.UI_OutGame;
using ZwischenProjekt_CW.PlayerClass;
using ZwischenProjekt_CW.Locations;
using System.Numerics;
using static ZwischenProjekt_CW.PlayerClass.Player;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW
{
    static class Mechanics
    {
        // Sammlung von globalen Variablen, die von überall aus erreichbar sein sollen.

        public static Game newGame = new Game();


        // Environment
        public static int days = 1;
        public static string timeOfDay = "Morning";
        public static List<string> daytimeList = new List<string>() { "Morning", "Noon", "Afternoon", "Evening", "Night" };
        public static int daytimeMarker = 0;
        public static int actionPool;

        // Player Actions
        public static bool isGather = false;
        public static bool isTravel = false;
        public static bool isCraft = false;
        public static bool didCraft = false;
        public static bool isLook = false;
        public static bool didAction = false;

        // Misc
        public static Random random = new Random();


        // Methods Action Handling
        public static void TakeOneAction(Location location, Player player)
        {
            // Does the player want to Gather, Travel, Craft or Look?
            if (isLook)
            {
                location.LocationInfo();
                didAction = true;
            }
            if (isGather)
            {
                player.GatherResources(location, player);
                didAction = true;
            }
            if (isCraft)
            {
                location.CraftMenu();
            }
            if (isTravel)
            {
                player.Travel(location, player);
                didAction = true;
            }
            player.AdjustHunger();
            AdvanceTime(player);

            location.Run();
        }

        public static void AdvanceTime(Player player)
        {
            if (didAction)
            {
                daytimeMarker++;
                timeOfDay = daytimeList[daytimeMarker];
                if (daytimeMarker == daytimeList.Count - 1)
                {
                    player.EndDay();
                }
            }
        }

        public static void ResetPlayerActionFlag()
        {
            isLook = false;
            isGather = false;
            isCraft = false;
            didCraft = false;
            isTravel = false;
            didAction = false;
        }

        public static bool YesNoMenu(string prompt)
        {
            bool choice;
            Menu yesNoMenu = new Menu("", ASCIIArt.yesNoArt, $"{prompt}", ["Yes", "No"]);
            int selectedIndex = yesNoMenu.GetMenuChoice();

            switch (selectedIndex)
            {
                case 0:
                    return choice = true;
                // yes
                case 1:
                    return choice = false;
                // no
                default:
                    return choice = false;
            }
        }



    }
}
