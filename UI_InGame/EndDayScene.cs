using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;
using static ZwischenProjekt_CW.Mechanics;
using static ZwischenProjekt_CW.Inventory;
using static ZwischenProjekt_CW.ConsoleUtilities;
using ZwischenProjekt_CW.PlayerClass;
using System.Numerics;

namespace ZwischenProjekt_CW.UI_InGame
{
    class EndDayScene : Scene
    {
        public EndDayScene(Game game) : base(game, ASCIIArt.endDayArt)
        {
        }

        public override void Run()
        {
            if (!Player.hasRaft)
            {
                Console.Clear();
                Console.WriteLine($"{ASCIIArt.sunsetArt}");
                Console.WriteLine($"{_artwork}");

                Eat(inventoryList[5], Game.PlayerList[0]);

                Console.WriteLine("Tired of your efforts you reflect what you have managed to do so far...");
                WaitForKeyPress();
                ClearConsoleLines(4);

                DailyResourcesString();
                CraftingSummary();

                Console.WriteLine($"The ambience of the {Game.ActiveLocationList[0]._name} lulls you to sleep.");
                WaitForKeyPress();
                ClearConsoleLines(4);

                ResetDay();


                MyGame.NewDayScene.Run();
            }
            else
            {
                MyGame.EpilogueScene.Run();
            }

        }

        private void ResetDay()
        {
            days++;
            timeOfDay = "Morning";
            daytimeMarker = 0;
            for (int index = 0; index < dailyResourcesList.Count; index++)
            {
                dailyResourcesList[index] = 0;
            }
        }

        private void DailyResourcesString()
        {
            Console.WriteLine($"In total you have gathered {dailyResourcesList[0]} logs, {dailyResourcesList[1]} sticks, {dailyResourcesList[2]} fibers, {dailyResourcesList[3]} small stones, {dailyResourcesList[4]} big stones and {dailyResourcesList[5]} food today.");
            WaitForKeyPress();
            ClearConsoleLines(4);
        }

        private void CraftingSummary()
        {
            if (Crafting.craftedTools.Count != 0) { Console.WriteLine($"So far you have crafted these tools: {String.Join(", ", Crafting.craftedTools)}"); }
            else Console.WriteLine("You haven't crafted any tools yet.");
            if (Crafting.craftedRaftParts.Count != 0) { Console.WriteLine($"You completed the following parts of the raft: {String.Join(", ", Crafting.craftedRaftParts)}"); }
            else Console.WriteLine("You have yet to build your first part of the raft.");
            WaitForKeyPress();
            ClearConsoleLines(5);
        }

        private void Eat(double availableFood, Player player)
        {
            CheckGameOver(player);
            if (Player.hasCampfire)
            {
                ConsumeFoodCF(availableFood, player);
                Console.WriteLine("You have enough food to survive another day.\nThanks to the campfire you can use your food more efficiently.");
            }
            else
            {
                ConsumeFood(availableFood, player);
                Console.WriteLine("You have enough food to survive another day.");
            }
            
            WaitForKeyPress();
            ClearConsoleLines(4);
        }

        private void ConsumeFoodCF(double availableFood, Player player)
        {
            double availableFoodCF = availableFood * 2;
            double neededFood = player._hungerMax - player._currentHunger;

            if (neededFood > availableFoodCF) // wenn nicht genug da ist
            {
                player._currentHunger += Math.Round(availableFoodCF);
                inventoryList[5] -= Math.Round(availableFoodCF / 2);
            }
            else // wenn genug da ist
            {
                player._currentHunger += Math.Round(neededFood);
                inventoryList[5] -= Math.Round(neededFood / 2);
            }
        }

        private void ConsumeFood(double availableFood, Player player)
        {
            double neededFood = player._hungerMax - player._currentHunger;

            if (neededFood > availableFood) // wenn nicht genug da ist
            {
                player._currentHunger += availableFood;
                inventoryList[5] -= availableFood;
            }
            else // wenn genug da ist
            {
                player._currentHunger += neededFood;
                inventoryList[5] -= neededFood;
            }
        }

        private void CheckGameOver(Player player)
        {
            if (player._currentHunger <= 0)
            {
                MyGame.GameOverScene.Run();
            }
        }
    }
}
