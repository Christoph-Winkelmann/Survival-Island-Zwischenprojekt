using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.ConsoleUtilities;

namespace ZwischenProjekt_CW.Locations
{
    class River : Location
    {
        // Constructor
        public River(Game game) : base(game, ASCIIArt.riverArt, "River", 1, 1.5, 1.75, 1.25, 1, 1.5, 0.5) { }
        
        // Methods
        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.BeachScene, MyGame.JungleScene };
            return possibleConnectionsObj;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "Beach", "Jungle" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings...\nYou are at a foresty river bank. In the distance you can hear a waterfall roaring.\n" +
                "A lot of berry bushes are growing here and there are tracks of wildlife all around.");
            WaitForKeyPress();
        }
    }

}
