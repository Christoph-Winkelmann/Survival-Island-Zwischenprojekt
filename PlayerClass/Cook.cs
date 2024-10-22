using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwischenProjekt_CW.PlayerClass
{
    internal class Cook : Player
    {
        public Cook(Game game, double currentHunger, double hungerMax, double strength, double vitality, double dexterity, double intelligence, double wisdom, double luck) 
            : base(game, "Cook", currentHunger, hungerMax, strength, vitality, dexterity, intelligence, wisdom, luck)
        {
        }

        public override void Special()
        {
            base.Special();
            Console.WriteLine("The Cook can cook better.");
            Inventory._food *= 2;
            Console.WriteLine($"{Inventory._food}");
            ConsoleUtilities.WaitForKeyPress();
        }
    }
}
