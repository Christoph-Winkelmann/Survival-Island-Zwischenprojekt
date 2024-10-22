using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;
using static ZwischenProjekt_CW.ConsoleUtilities;

namespace ZwischenProjekt_CW.Locations
{
    class Cave : Location
    {
        public Cave(Game game) : base(game, ASCIIArt.beachArt, "Cave", 0.25, 1, 0.25, 1.75, 0.75, 0.75, 1.5)
        {

        }

        // Methods

        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.BeachScene, MyGame.RiverScene, MyGame.JungleScene, MyGame.HillsScene, MyGame.GrasslandsScene };
            return possibleConnectionsObj;
        }

        public List<Location> GetKnownConnections()
        {
            List<Location> knownConnections = new List<Location>();
            return knownConnections;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "River", "Grasslands" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings. You are in a maze-like cave system...");
            WaitForKeyPress();
        }
    }
}
