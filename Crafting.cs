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

namespace ZwischenProjekt_CW
{
    static class Crafting
    {
        // Game reference
        public static Game game = new Game();

        // Tools Recipes
        public static List<double> axeRecipe = new List<double>() { 0, 10, 10, 5, 0, 0 };
        public static List<double> basketRecipe = new List<double>() { 0, 30, 30, 0, 0, 0 };
        public static List<double> spearRecipe = new List<double>() { 1, 0, 10, 5, 0, 0 };
        public static List<double> campfireRecipe = new List<double>() { 10, 20, 10, 0, 10, 0 };
        public static List<double> shelterRecipe = new List<double>() { 20, 50, 100, 0, 20, 0 };

        // Raft Parts Recipes
        public static List<bool> raftRecipe = new List<bool>() { Player.hasBody, Player.hasSail, Player.hasRudder, Player.hasPaddle, Player.hasRations };
        public static List<double> raftBodyRecipe = new List<double>() { 100, 0, 100, 0, 0, 0 };
        public static List<double> raftSailRecipe = new List<double>() { 2, 10, 200, 0, 0, 0 };
        public static List<double> raftRudderRecipe = new List<double>() { 0, 50, 50, 0, 0, 0 };
        public static List<double> raftPaddleRecipe = new List<double>() { 1, 10, 10, 0, 0, 0 };
        public static List<double> raftRationsRecipe = new List<double>() { 0, 0, 50, 0, 0, 50 };

        // Crafting Lists
        public static List<string> craftedTools = new List<string>();
        public static List<string> craftedRaftParts = new List<string>();
        public static List<string> notCraftedTools = new List<string>()
        {
            $"Axe ({axeRecipe[1]} Sticks, {axeRecipe[2]} Fibers, {axeRecipe[3]} Small Stones) - get more logs",
            $"Basket ({basketRecipe[1]} Sticks, {basketRecipe[2]} Fibers) - get more sticks, fibers, small stones and food",
            $"Spear ({spearRecipe[0]} Logs, {spearRecipe[2]} Fibers, {spearRecipe[3]} Small Stones) !!! craftable, but no effect yet !!!",
            $"Campfire ({campfireRecipe[0]} Logs, {campfireRecipe[1]} Sticks, {campfireRecipe[2]} Fibers, {campfireRecipe[4]} Big Stones) - consume less food per meal",
            $"Shelter ({shelterRecipe[0]} Logs, {shelterRecipe[1]} Sticks, {shelterRecipe[2]} Fibers, {shelterRecipe[4]} Big Stones) !!! craftable, but no effect yet !!!",
            $"Return"
        };
        public static List<string> notCraftedRaftParts = new List<string>()
        {
            $"Raft Body ({raftBodyRecipe[0]} Logs, {raftBodyRecipe[2]} Fibers)",
            $"Raft Sail ({raftSailRecipe[0]} Logs, {raftSailRecipe[1]} Sticks, {raftSailRecipe[2]} Fibers)",
            $"Raft Rudder ({raftRudderRecipe[1]} Sticks, {raftRudderRecipe[2]} Fibers)",
            $"Raft Paddle ({raftPaddleRecipe[0]} Log, {raftPaddleRecipe[1]} Sticks, {raftPaddleRecipe[2]} Fibers)",
            $"Raft Rations ({raftRationsRecipe[2]} Fibers, {raftRationsRecipe[5]} Food)",
            $"Return"
        };

        // public static List<List<double>> RevipeList = new List<List<double>>(); // Maybe later: make this list contain all the crafting recipe Lists to make thiis class more modular.

        // Misc

        // Methods
        public static void CraftTool()
        {
            Menu craftMenu = new Menu($"{Inventory.DisplayInventory()}", $"{ASCIIArt.craftToolsArt}",
                $"Crafted tools: {string.Join(", ", craftedTools)}\n" +
                $"Select something you want to craft:", notCraftedTools);

            int selectedIndex = craftMenu.GetMenuChoice();
            switch (selectedIndex)
            {
                case 0:
                    CraftAxe(); break;
                case 1:
                    CraftBasket(); break;
                case 2:
                    CraftSpear(); break;
                case 3:
                    CraftCampfire(); break;
                case 4:
                    CraftShelter(); break;
                case 5: return;
            }
        }

        public static void CraftRaftPart()
        {
            Menu craftMenu = new Menu($"{Inventory.DisplayInventory()}", $"{ASCIIArt.craftRaftPartsArt}",
                $"Crafted raft parts: {string.Join(", ", craftedRaftParts)}\n" +
                $"Select something you want to craft:", notCraftedRaftParts);

            int selectedIndex = craftMenu.GetMenuChoice();
            switch (selectedIndex)
            {
                case 0:
                    CraftRaftBody(); break;
                case 1:
                    CraftRaftSail(); break;
                case 2:
                    CraftRaftRudder(); break;
                case 3:
                    CraftRaftPaddle(); break;
                case 4:
                    CraftRaftRations(); break;
                case 5: return;
            }
            CraftRaftPart();
        }


        // Tools Crafting Methods
        public static void CraftAxe()
        {
            if (!Player.hasAxe)
            {
                if (CheckCraftingCost(axeRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the axe?"))
                    {
                        SpendResources(axeRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft yourself a makeshift axe. This will make cutting logs a lot easier.");
                        Player.hasAxe = true;
                        notCraftedTools[0] = "Axe: Done";
                        craftedTools.Add("Axe");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }

        }

        public static void CraftBasket()
        {
            if (!Player.hasBasket)
            {
                if (CheckCraftingCost(basketRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the basket?"))
                    {
                        SpendResources(basketRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft yourself a makeshift basket. This will make collection sticks, fibers, small stones and food a lot easier.");
                        Player.hasBasket = true;
                        notCraftedTools[1] = "Basket: Done";
                        craftedTools.Add("Basket");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftSpear()
        {
            if (!Player.hasSpear)
            {
                if (CheckCraftingCost(spearRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the spear?"))
                    {
                        SpendResources(spearRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft yourself a makeshift spear. This will keep you safe while roaming the island.");
                        Player.hasSpear = true;
                        notCraftedTools[2] = "Spear: Done";
                        craftedTools.Add("Spear");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftCampfire()
        {
            if (!Player.hasCampfire)
            {
                if (CheckCraftingCost(campfireRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the campfire?"))
                    {
                        SpendResources(campfireRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft yourself a makeshift campfire. With this you can use your food more efficiently.");
                        Player.hasCampfire = true;
                        notCraftedTools[3] = "Campfire: Done";
                        craftedTools.Add("Campfire");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftShelter()
        {
            if (!Player.hasShelter)
            {
                if (CheckCraftingCost(shelterRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the shelter?"))
                    {
                        SpendResources((shelterRecipe));
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft yourself a makeshift shelter. This will protect you from your environment.");
                        Player.hasShelter = true;
                        notCraftedTools[4] = "Shelter: Done";
                        craftedTools.Add("Shelter");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }


        // Raft Crafting Methods
        public static void CraftRaft()
        {
            if (!Player.hasRaft)
            {
                if (CheckRaftParts(Player.raftPartsList))
                {
                    if (Mechanics.YesNoMenu("Craft the raft?"))
                    {
                        for (int i = 0; i < Player.raftPartsList.Count; i++)
                        {
                            Player.raftPartsList[i] = false;
                        }
                        Console.WriteLine();
                        Console.WriteLine("You take all the seperate parts you have crafted and assemble them to build a beautiful raft. Finally you can escape the island.");
                        Player.hasRaft = true;
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You have not built all the necessary parts.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftRaftBody()
        {
            if (!Player.hasBody)
            {
                if (CheckCraftingCost(raftBodyRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the raft body?"))
                    {
                        SpendResources(raftBodyRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft the body of the raft. One step further to escaping this island.");
                        Player.hasBody = true;
                        Player.raftPartsList[0] = true;
                        notCraftedRaftParts[0] = "Raft Body: Done";
                        craftedRaftParts.Add("Raft Body");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftRaftSail()
        {
            if (!Player.hasSail)
            {
                if (CheckCraftingCost(raftSailRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the raft sail?"))
                    {
                        SpendResources(raftSailRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft the sail for the raft. One step further to escaping this island.");
                        Player.hasSail = true;
                        Player.raftPartsList[1] = true;
                        notCraftedRaftParts[1] = "Raft Sail: Done";
                        craftedRaftParts.Add("Raft Sail");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftRaftRudder()
        {
            if (!Player.hasRudder)
            {
                if (CheckCraftingCost(raftRudderRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the raft rudder?"))
                    {
                        SpendResources(raftRudderRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft the rudder for the raft. One step further to escaping this island.");
                        Player.hasRudder = true;
                        Player.raftPartsList[2] = true;
                        notCraftedRaftParts[2] = "Raft Rudder: Done";
                        craftedRaftParts.Add("Raft Rudder");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftRaftPaddle()
        {
            if (!Player.hasPaddle)
            {
                if (CheckCraftingCost(raftPaddleRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the raft paddle?"))
                    {
                        SpendResources(raftPaddleRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft the paddle for the raft. One step further to escaping this island.");
                        Player.hasPaddle = true;
                        Player.raftPartsList[3] = true;
                        notCraftedRaftParts[3] = "Raft Paddle: Done";
                        craftedRaftParts.Add("Raft Paddle");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        public static void CraftRaftRations()
        {
            if (!Player.hasRations)
            {
                if (CheckCraftingCost(raftRationsRecipe))
                {
                    if (Mechanics.YesNoMenu("Craft the raft Rations?"))
                    {
                        SpendResources(raftRationsRecipe);
                        Console.WriteLine();
                        Console.WriteLine("You use some of your resources to craft the rations for the raft. You make sure not to starve once your out at sea.");
                        Player.hasRations = true;
                        Player.raftPartsList[4] = true;
                        notCraftedRaftParts[4] = "Raft Rations: Done";
                        craftedRaftParts.Add("Raft Rations");
                        Mechanics.didAction = true;
                        Mechanics.didCraft = true;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough resources.");
                }
                WaitForKeyPress();
            }
        }

        // Other Methods
        public static bool CheckCraftingCost(List<double> recipe)
        {
            bool check = true;
            for (int j = 0; j < Inventory.inventoryList.Count; j++)
            {
                if (recipe[j] <= Inventory.inventoryList[j])
                {

                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        public static void SpendResources(List<double> recipe)
        {
            for (int j = 0; j < Inventory.inventoryList.Count; j++)
            {
                Inventory.inventoryList [j] -= recipe[j];
            }
        }

        public static bool CheckRaftParts(List<bool> necessaryParts)
        {



            bool check = true;
            for (int j = 0; j < necessaryParts.Count; j++)
            {
                if (necessaryParts[j] == true)
                {

                }
                else
                {
                    check= false;
                }
            }
            return check;
        }
    }
}
