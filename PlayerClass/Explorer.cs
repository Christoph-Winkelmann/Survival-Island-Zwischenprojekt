using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwischenProjekt_CW.PlayerClass
{
    internal class Explorer : Player
    {
        public Explorer(Game game, double currentHunger, double hungerMax, double strength, double vitality, double dexterity, double intelligence, double wisdom, double luck) 
            : base(game, "Explorer", currentHunger, hungerMax, strength, vitality, dexterity, intelligence, wisdom, luck)
        {
        }
    }
}
