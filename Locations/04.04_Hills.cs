using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.ConsoleUtilities;

namespace ZwischenProjekt_CW.Locations
{
    class Hills : Location
    {
        // Constructor
        public Hills(Game game) : base(game, ASCIIArt.hillsArt, "Hills", 0.25, 0.5, 0.75, 1.5, 1.75, 0.25, 0.75) { }

        // Methods
        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.JungleScene, MyGame.GrasslandsScene };
            return possibleConnectionsObj;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "Jungle", "Grasslands" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings...\nThis area is hilly and some of them tower really high above you.\nThis place is pretty bare of vegetation," +
                " but this is the perfect place to get some of these big stones.");
            WaitForKeyPress();
        }
    }
}
