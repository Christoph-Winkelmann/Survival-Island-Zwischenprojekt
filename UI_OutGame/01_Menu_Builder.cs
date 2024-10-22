using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.PlayerClass;
using static ZwischenProjekt_CW.Inventory;

namespace ZwischenProjekt_CW.UI_OutGame
{
    class Menu
    {
        public static Game game = new Game();


        // Fields
        private string _header;
        private string _artwork;
        private string _menuPromt;
        private int _selectedIndex;
        private List<string> _menuOptions;

        // Constructor
        public Menu(string header, string artwork, string promt, List<string> options)
        {
            _header = header;
            _artwork = artwork;
            _menuPromt = promt;
            _menuOptions = options;
            _selectedIndex = 0;
        }


        private void DisplayMenuOptions() // Listet die Elemente des Arrays "_menuOptions" auf und setzt ein Highlight auf die aktive Auswahl "_selectedIndex"
        {
            Console.WriteLine(_header);
            Console.WriteLine();
            Console.WriteLine(_artwork);
            Console.WriteLine();
            Console.WriteLine(_menuPromt);
            Console.WriteLine();
            for (int i = 0; i < _menuOptions.Count; i++)
            {
                string currentOption = _menuOptions[i];
                string prefix;
                string suffix;

                if (i == _selectedIndex)
                {
                    prefix = "<<";
                    suffix = ">>";
                }
                else
                {
                    prefix = "  ";
                    suffix = "";
                }
                Console.WriteLine($"{prefix} {currentOption} {suffix}");
            }
            Console.ResetColor();
        }

        public int GetMenuChoice() // Gleicht die aktive Auswahl entsprechend der gedrückten Pfeiltaste an, beendet Methode mit Drücken von "Enter", gibt "_selectedIndex" Wert als "int" zurück
        {

            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                //DisplayMainTitle();
                DisplayMenuOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (_selectedIndex == _menuOptions.Count - 1)
                    {
                        _selectedIndex = 0;
                    }
                    else _selectedIndex++;
                }
                else if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (_selectedIndex == 0)
                    {
                        _selectedIndex = _menuOptions.Count- 1;
                    }
                    else _selectedIndex--;
                }
            }
            while (keyPressed != ConsoleKey.Enter);

            return _selectedIndex; ;
        }

        




    }
}
