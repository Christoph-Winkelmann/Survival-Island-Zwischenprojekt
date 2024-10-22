using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Locations;
using ZwischenProjekt_CW.PlayerClass;
using ZwischenProjekt_CW.UI_OutGame;
using static ZwischenProjekt_CW.ConsoleUtilities;

namespace ZwischenProjekt_CW
{
    static class Inventory
    {
        // Game Reference
        //public static Game invGame = new Game();

        // Fields Inventory
        public static double _logs = 0;
        public static double _sticks = 0;
        public static double _fibers = 0;
        public static double _smallStones = 0;
        public static double _bigStones = 0;
        public static double _food = 0;

        // Fields daily Harvest
        public static double dailyLogs;
        public static double dailySticks;
        public static double dailyFibers;
        public static double dailySmallStones;
        public static double dailyBigStones;
        public static double dailyFood;

        // Inventory Lists
        public static List<double> inventoryList = new List<double>() { _logs, _sticks, _fibers, _smallStones, _bigStones, _food };
        //public static List<double> inventoryList = new List<double>() { 1000, 1000, 1000, 1000, 1000, 1000 };
        public static List<double> dailyResourcesList = new List<double>() { dailyLogs, dailySticks, dailyFibers, dailySmallStones, dailyBigStones, dailyFood };


        // Methods
        public static string DisplayInventory()
        {
            string header = $"Logs ({inventoryList[0]}) | Sticks ({inventoryList[1]}) | Fibers ({inventoryList[2]}) | Small Stones ({inventoryList[3]}) | Big Stones ({inventoryList[4]}) | Food ({inventoryList[5]})";
            return header;
        }
    }

}

