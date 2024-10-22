using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwischenProjekt_CW.PlayerClass
{
    internal class Carpenter : Player
    {
        public Carpenter(Game game, double currentHunger, double hungerMax, double strength, double vitality, double dexterity, double intelligence, double wisdom, double luck) 
            : base(game, "Carpenter", currentHunger, hungerMax, strength, vitality, dexterity, intelligence, wisdom, luck)
        {
        }

        public override void Special()
        {
            base.Special();
            Console.WriteLine("The Carpenter can craft better.");
            ConsoleUtilities.WaitForKeyPress();
        }

    }
}
