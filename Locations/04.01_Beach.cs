using System.Reflection.PortableExecutable;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.Inventory;
using static ZwischenProjekt_CW.ConsoleUtilities;

namespace ZwischenProjekt_CW.Locations
{
    class Beach : Location
    {
        // Constructor
        public Beach(Game game) : base(game, ASCIIArt.beachArt, "Beach", 0.25, 1, 0.25, 1.75, 0.75, 0.75, 1.5) { }

        // Methods
        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.RiverScene, MyGame.GrasslandsScene };
            return possibleConnectionsObj;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "River", "Grasslands" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings...\nYou are at a beautiful sandy beach. The waves calmly wash ashore and seagulls fight over clams und fish.\n" +
                "Aside from pebbles and a gorgeous view there is nothing much here.");
            ConsoleUtilities.WaitForKeyPress();
        }
    }
}
