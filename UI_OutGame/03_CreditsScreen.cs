using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    internal class CreditsScreen : Scene
    {
        public CreditsScreen(Game game) : base(game, ASCIIArt.creditsArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{ASCIIArt.creditsArt}");
            Console.WriteLine();
            Console.WriteLine(@"
Tools:
Text to ASCII Art Generator: http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20

YouTube Tutorials, deren Inhalte hier eingeflossen sind:
Menu Concept - Michael Hadley: https://www.youtube.com/watch?v=qAWhGEPMlS8
Scene Structure - Michael Hadley: https://www.youtube.com/watch?v=eBadZxYe6I4&list=PL-LDQE9x9hLwldZPPGwqXixr-_DfINfxk&index=33

Art Assets:
Beach Scene: by jgs - https://www.asciiart.eu/nature/beach
River Scene: by Lester AMC - https://www.asciiart.eu/nature/waterfall
Jungle Scene: by jgs - https://asciiart.website/index.php?art=plants/trees
Hills Scene: by unknown - https://www.asciiart.eu/nature/mountains
Grasslands Scene: Flower garden by Joan G. Stark - https://www.asciiart.eu/plants/flowers
EndDayScene: by unknown - https://www.asciiart.eu/nature/sunset
");
            ConsoleUtilities.WaitForKeyPress();
            MyGame.TitleScreen.Run();
        }
    }
}
