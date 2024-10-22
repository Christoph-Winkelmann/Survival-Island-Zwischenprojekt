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
    class Jungle : Location
    {
        // Constructor
        public Jungle(Game game) : base(game, ASCIIArt.jungleArt, "Jungle", 1.75, 1.75, 1.75, 0.5, 0.75, 1.5, 0.25) { }
        
        // Methods
        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.RiverScene, MyGame.HillsScene };
            return possibleConnectionsObj;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "River", "Hills" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings...\nYou are at a lush jungle. The vegetation is so thick that not much sunlight is coming through.\n" +
                "It's hard to navigate here, but this is probably the best spot to get wood and other plant-based material...\n" +
                "...was that a growl I just heard?");
            WaitForKeyPress();
        }
    }
}
