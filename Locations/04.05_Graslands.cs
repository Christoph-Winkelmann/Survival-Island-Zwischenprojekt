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
    class Grasslands : Location
    {
        // Boa Constructor ;)
        public Grasslands(Game game) : base(game, ASCIIArt.grasslandsArt, "Grasslands", 1, 1, 1.5, 1.25, 0.75, 1.25, 1.25) { }

        // Methods
        public override List<Location> GetConnectionsObj()
        {
            List<Location> possibleConnectionsObj = new List<Location>() { MyGame.BeachScene, MyGame.HillsScene };
            return possibleConnectionsObj;
        }

        public override List<string> GetConnectionsString()
        {
            List<string> possibleConnectionsString = new List<string> { "Beach", "Hills" };
            return possibleConnectionsString;
        }

        public override void LocationInfo()
        {
            base.LocationInfo();
            Console.WriteLine("You inspect your surroundings...\nMeadows with wild flowers spread as far as the eye can see. The occasional tree accentuates the landscape.\n" +
                "This place is very peaceful. Maybe you don't even have to leave. Maybe you will build a house right here?\nYou shake that thought away. Time to get on with your day.");
            WaitForKeyPress();
        }
    }
}
