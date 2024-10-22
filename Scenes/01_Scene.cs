using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwischenProjekt_CW.Scenes
{
    class Scene
    {
        protected Game MyGame;
        public string _artwork;

        public Scene(Game game, string artwork) 
        {
            MyGame = game;
            _artwork = artwork;
        }

        virtual public void Run()
        {

        }


    }
}
