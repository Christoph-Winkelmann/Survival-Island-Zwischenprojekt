using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Locations;
using ZwischenProjekt_CW.PlayerClass;
using ZwischenProjekt_CW.UI_InGame;
using ZwischenProjekt_CW.UI_OutGame;

namespace ZwischenProjekt_CW
{
    class Game
    {
        // Menu Objects
        public TitleScreen TitleScreen;
        public CreditsScreen CreditsScreen;
        public AboutScreen AboutScreen;
        public ExitScreen ExitScreen;
        public EndScreen EndScreen;

        // InGame Scenes
        public IntroScene IntroScene;
        public EndDayScene EndDayScene;
        public NewDayScene NewDayScene;
        public EpilogueScene EpilogueScene;
        public GameOverScene GameOverScene;

        // Locations
        public Beach BeachScene;
        public River RiverScene;
        public Jungle JungleScene;
        public Hills HillsScene;
        public Grasslands GrasslandsScene;
        public Cave CaveScene;
        public static List<Location> ActiveLocationList = new List<Location>() { };

        // Player
        public Player MyPlayer;
        public Cook MyCook;
        public Carpenter MyCarpenter;
        public Soldier MySoldier;
        public Explorer MyExplorer;
        public Tourist MyTourist;
        public static List<Player> PlayerList = new List<Player>() { };



        // Constructor
        public Game()
        {
            // Menus
            TitleScreen = new TitleScreen(this);
            CreditsScreen = new CreditsScreen(this);
            AboutScreen = new AboutScreen(this);
            ExitScreen = new ExitScreen(this);
            EndScreen = new EndScreen(this);

            // InGame Scenes
            IntroScene = new IntroScene(this);
            EndDayScene = new EndDayScene(this);
            NewDayScene = new NewDayScene(this);
            EpilogueScene = new EpilogueScene(this);
            GameOverScene = new GameOverScene(this);

            // Locations
            BeachScene = new Beach(this);
            RiverScene = new River(this);
            JungleScene = new Jungle(this);
            HillsScene = new Hills(this);
            GrasslandsScene = new Grasslands(this);
            CaveScene = new Cave(this);

            // Player
            MyPlayer = new Player(this, "", 0, 0, 0, 0, 0, 0, 0, 0);
            MyCook = new Cook(this, 130, 130, 1, 1.25, 1.5, 1.25, 1.5, 1);
            MyCarpenter = new Carpenter(this, 100, 100, 1.25, 1.5, 1.25, 1, 1.25, 1);
            MySoldier = new Soldier(this, 100, 100, 1, 0.75, 1.25, 1, 1.25, 0.75);
            MyExplorer = new Explorer(this, 120, 120, 1, 0.75, 0.75, 1.5, 1.75, 1);
            MyTourist = new Tourist(this, 100, 100, 1, 1, 1, 1, 1, 3);
            
        }


        // Methods
        public void Start()
        {
            DisclaimerScene.ShowDisclaimer();
            ActiveLocationList.Add(BeachScene);
            TitleScreen.Run();
        }
    }
}