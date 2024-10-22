using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Locations;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.Mechanics;
using static ZwischenProjekt_CW.Crafting;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.PlayerClass
{
    class Player
    {
        // Game Referenve
        Game newGame;

        // Fields Crafting
        public static bool hasAxe = false;
        public static bool hasBasket = false;
        public static bool hasSpear = false;
        public static bool hasCampfire = false;
        public static bool hasShelter = false;
        public static bool hasRaft = false;
        public static bool hasBody = false;
        public static bool hasSail = false;
        public static bool hasRudder = false;
        public static bool hasPaddle = false;
        public static bool hasRations = false;
        public static List<bool> raftPartsList = new List<bool>() { hasBody, hasSail, hasRudder, hasPaddle, hasRations };

        // Fields Exploration
        public static bool foundCaveEntranceBeach = false;
        public static bool foundCaveEntranceRiver = false;
        public static bool foundCaveEntranceJungle = false;
        public static bool foundCaveEntranceHills = false;
        public static bool foundCaveEntranceGrasslands = false;

        // Fields - Bio
        public string _name;
        public string _profession;
        public double _hungerMax;
        public double _currentHunger;
        public static bool _starved = false;

        // Fields Stats
        public double _strength;
        public double _vitality;
        protected double _dexterity;
        protected double _intelligence;
        protected double _wisdom;
        protected double _luck;

        // Player Action Flags

        // Constructor
        public Player(Game game, string profession, double currentHunger, double hungerMax, double strength, double vitality, double dexterity, double intelligence, double wisdom, double luck)
        {
            newGame = game;
            _profession = profession;
            _currentHunger = currentHunger;
            _hungerMax = hungerMax;
            _strength = strength;
            _vitality = vitality;
            _dexterity = dexterity;
            _intelligence = intelligence;
            _wisdom = wisdom;
            _luck = luck;
        }

        public void CharacterCreation()
        {
            ChooseProfession();
            EnterName();
            newGame.IntroScene.Run();
        }

        public void ChooseProfession()
        {
            Menu createCharacterMenu = new Menu("", $"{ASCIIArt.professionArt}", "Your profession influences a lot of things in the game...", ["Cook", "Carpenter", "Soldier", "Explorer", "Tourist"]);
            int selectedIndex = createCharacterMenu.GetMenuChoice();
            switch (selectedIndex)
            {
                case 0:
                    Game.PlayerList.Add(newGame.MyCook);
                    break;
                case 1:
                    Game.PlayerList.Add(newGame.MyCarpenter);
                    break;
                case 2:
                    Game.PlayerList.Add(newGame.MySoldier);
                    break;
                case 3:
                    Game.PlayerList.Add(newGame.MyExplorer);
                    break;
                case 4:
                    Game.PlayerList.Add(newGame.MyTourist);
                    break;

            }
        }

        public void EnterName()
        {
            int selectedIndex;
            do
            {
                do
                {
                    if (Game.PlayerList[0]._name == null)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"{ASCIIArt.nameArt}");
                        Console.Write("Please enter your name? ");
                        Game.PlayerList[0]._name = Console.ReadLine();
                    }
                } while (Game.PlayerList[0]._name == null);

                Menu confirmMenu = new Menu("", ASCIIArt.nameArt, $"Your current name is {Game.PlayerList[0]._name}. Is that correct?", ["Yes", "No"]);
                selectedIndex = confirmMenu.GetMenuChoice();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine($"Your name has been set to: {Game.PlayerList[0]._name}.");
                        ConsoleUtilities.WaitForKeyPress();
                        // continue
                        break;
                    case 1:
                        Game.PlayerList[0]._name = null;
                        break;
                }
            } while (selectedIndex != 0);
        }

        public void Travel(Location location, Player player)
        {
            Menu travelMenu = new Menu($"{location.DisplayHeader()}", $"{location._artwork}", "Where would you like to go?", location.GetConnectionsString());
            int selectedIndex = travelMenu.GetMenuChoice();

            Console.Clear();
            Console.Write($"You leave the {location._name}. ");
            Game.ActiveLocationList.Clear();

            switch (selectedIndex)
            {
                case 0:
                    Game.ActiveLocationList.Add(location.GetConnectionsObj()[0]);
                    Console.WriteLine($"After a while you arrive at the {location.GetConnectionsString()[0]}.");
                    break;
                case 1:
                    Game.ActiveLocationList.Add(location.GetConnectionsObj()[1]);
                    Console.WriteLine($"After a while you arrive at the {location.GetConnectionsString()[1]}.");
                    break;
            }
            ConsoleUtilities.WaitForKeyPress();
        }

        public void GatherResources(Location location, Player player)
        {
            Console.Clear();
            Console.WriteLine($"You search the {location._name} for resources.\n");

            List<double> newRes = new List<double>();

            double tempLog, tempSticks, tempFibers, tempSSTones, tempBStones, tempFood;

            int notToolModLow = random.Next(0, 6);
            int noToolModHigh = random.Next(0, 11);
            int hasAxeMod = random.Next(0, 11);
            int hasBasketMod = random.Next(0, 21);

            // Logs
            if (hasAxe) tempLog = Math.Round(hasAxeMod * location._logsMod * player._strength); else tempLog = Math.Round(notToolModLow * location._logsMod * player._strength);
            Inventory.inventoryList[0] += tempLog; Inventory.dailyResourcesList[0] += tempLog;

            // Sticks
            if (hasBasket) tempSticks = Math.Round(hasBasketMod * location._sticksMod * player._dexterity); else tempSticks = Math.Round(noToolModHigh * location._sticksMod * player._dexterity);
            Inventory.inventoryList[1] += tempSticks; Inventory.dailyResourcesList[1] += tempSticks;

            // Fibers
            if (hasBasket) tempFibers = Math.Round(hasBasketMod * location._fibersMod * player._wisdom); else tempFibers = Math.Round(noToolModHigh * location._fibersMod * player._wisdom);
            Inventory.inventoryList[2] += tempFibers; Inventory.dailyResourcesList[2] += tempFibers;

            // Small Stones
            if (hasBasket) tempSSTones = Math.Round(hasBasketMod * location._smallStonesMod * player._dexterity); else tempSSTones = Math.Round(noToolModHigh * location._smallStonesMod * player._dexterity);
            Inventory.inventoryList[3] += tempSSTones; Inventory.dailyResourcesList[3] += tempSSTones;

            // Big Stones
            tempBStones = Math.Round(notToolModLow * location._bigStoneslogsMod * player._strength);
            Inventory.inventoryList[4] += tempBStones; Inventory.dailyResourcesList[4] += tempBStones;

            // Food
            if (hasBasket) tempFood = Math.Round(hasBasketMod * location._foodMod * player._wisdom); else tempFood = Math.Round(noToolModHigh * location._foodMod * player._wisdom);
            Inventory.inventoryList[5] += tempFood; Inventory.dailyResourcesList[5] += tempFood;

            Console.WriteLine($"Time passes and you have gathered {tempLog} logs, {tempSticks} sticks, {tempFibers} fibers, {tempSSTones} small stones, {tempBStones} big stones and {tempFood} food.");
            if (hasAxe) Console.Write("Your axe helped a lot.");
            if (hasBasket) Console.WriteLine("Your basket increased your yield.");
            Console.WriteLine();
            Console.WriteLine("You carry your haul back to your camp.");

            ConsoleUtilities.WaitForKeyPress();
        }

        public void EndDay()
        {
            newGame.EndDayScene.Run();
        }

        public virtual void Special()
        {
            Console.Clear();
            Console.Write("Special Action: ");
        }


        public void AdjustHunger()
        {
            if (isGather) { _currentHunger -= Math.Round(10 * _vitality); /*isGather = false;*/ }
            if (isTravel) { _currentHunger -= Math.Round(7 * _vitality); /*isTravel = false;*/ }
            if (didCraft) { _currentHunger -= Math.Round(5 * _vitality); /*isCraft = false;*/ }
            if (isLook) { _currentHunger -= Math.Round(2 * _vitality); /*isLook = false; */}
        }
    }
}
