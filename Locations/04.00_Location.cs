using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.PlayerClass;
using ZwischenProjekt_CW.Scenes;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.ConsoleUtilities;
using static ZwischenProjekt_CW.Inventory;

namespace ZwischenProjekt_CW.Locations
{
    class Location : Scene
    {
        public string _name;
        public double _logsMod;
        public double _sticksMod;
        public double _fibersMod;
        public double _smallStonesMod;
        public double _bigStoneslogsMod;
        public double _foodMod;
        public double _safetyMod;

        // Constructor
        public Location(Game game, string artwork, string name, double logsMod, double sticksMod, double fibersMod, double smallStonesMod, double bigStonesMod, double foodMod, double safetyMod)
            : base(game, artwork)
        {
            _name = name;
            _logsMod = logsMod;
            _sticksMod = sticksMod;
            _fibersMod = fibersMod;
            _smallStonesMod = smallStonesMod;
            _bigStoneslogsMod = bigStonesMod;
            _foodMod = foodMod;
            _safetyMod = safetyMod;
        }
        public override void Run()
        {
            Mechanics.ResetPlayerActionFlag();
            Menu locationMenu = new Menu($"{DisplayHeader()}", $"{Game.ActiveLocationList[0]._artwork}", $"You are at the {Game.ActiveLocationList[0]._name}. What do you want to do?", ["Look around", "Gather Resources", "Craft", "Travel"]);

            int selectedIndex = locationMenu.GetMenuChoice();

            switch (selectedIndex)
            {
                case 0:
                    Mechanics.isLook = true;
                    break;
                case 1:
                    Mechanics.isGather = true;
                    break;
                case 2:
                    Mechanics.isCraft = true;
                    break;
                case 3:
                    Mechanics.isTravel = true;
                    break;
            }
            Mechanics.TakeOneAction(Game.ActiveLocationList[0], Game.PlayerList[0]);
        }

        public void CraftMenu()
        {
            List<string> options = new List<string>() { "Craft Tools", "Craft Raft Parts", "Craft the Raft", "Return" };

            Menu craftMenu = new Menu(DisplayHeader(), $"{ASCIIArt.craftingArt}",
                $"Crafted tools: {string.Join(", ", Crafting.craftedTools)}\n" +
                $"Finished parts of the raft: {string.Join(", ", Crafting.craftedRaftParts)}\n\n",
                options);

            int selectedIndex = craftMenu.GetMenuChoice();
            switch (selectedIndex)
            {
                case 0:
                    Crafting.CraftTool(); break;
                case 1:
                    Crafting.CraftRaftPart(); break;
                case 2:
                    Crafting.CraftRaft(); break;
                case 3:
                    Game.ActiveLocationList[0].Run(); break;
            }
        }

        public virtual List<Location> GetConnectionsObj()
        {
            return null;
        }

        public virtual List<string> GetConnectionsString()
        {
            return null;
        }

        public string DisplayHeader()
        {
            string header = $"Name: {Game.PlayerList[0]._name}, the {Game.PlayerList[0]._profession} | Hunger: ({Game.PlayerList[0]._currentHunger}/{Game.PlayerList[0]._hungerMax}) | Current Location: {Game.ActiveLocationList[0]._name} | Day: {Mechanics.days} | Daytime: {Mechanics.timeOfDay}\n" +
                $"Inventory: Logs ({inventoryList[0]}) | Sticks ({inventoryList[1]}) | Fibers ({inventoryList[2]}) | Small Stones ({inventoryList[3]}) | Big Stones ({inventoryList[4]}) | Food ({inventoryList[5]})";
            return header;
        }

        public virtual void LocationInfo()
        {
            Console.Clear();
            Console.WriteLine(DisplayHeader());
            Console.WriteLine();
            Console.WriteLine(_artwork);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
