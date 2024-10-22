using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    internal class AboutScreen : Scene
    {
        public AboutScreen(Game game) : base(game, ASCIIArt.aboutArt)
        {
        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine($"{ASCIIArt.aboutArt}");
            Console.WriteLine();
            Console.WriteLine(@"

Bei ""Survival Island"" handelt es sich um ein Zwischenprojekt im Rahmen meiner Umschulung zum Fachinformatiker (Anwendungsentwicklung) bei der Lutz + Grub GmbH.

Die Vorgaben sind:
    - Erstellung einer Konsolen-App in C# unter Einbezug der Grundlagen des Programmierens.
    - Dokumentation des Prozesses.


Worum geht es bei ""Survival Island""?
Mein Programm ist ein Survival-Spiel. Der Anwender schlüpft in die Rolle eines Charakters, der aus unbekannten Gründen auf einer einsamen Insel gestrandet ist. 
Um zu überleben, müssen Rohstoffe gesammelt, die Insel erforscht, Werkzeuge gebaut und zuletzt ein Floß gebaut werden. 
Dabei gilt es, genug Nahrung zu haben, um nicht zu verhungern.


Gameplay
Zu Beginn sucht sich der Spieler den Beruf seines Charakters aus. Jeder Beruf hat eigene Spielwerte, die verschiedene Dinge im Spiel beeinflussen (Menge der 
gesammelten Rohstoffe, Kapazität der Hunger-Leiste, wie viel Hunger pro AKtion verbraucht wird und ein Glücks-Faktor). 
Der Spieler kann seinem Charakter noch einen Namen geben.
Das Spiel führt den Spieler durch Menüs, in denen der Spieler je nach Kontext seine Aktionen frei wählen kann.
Jede Aktion verbraucht Zeit und Hunger. Am Ende des Tages gibt es eine Zusammenfassung, der Charakter isst und ein neuer Tag beginnt.


Siegbedingung
Sobald der Spieler das Floß gebaut hat und der Charakter am Ende des Tages nicht verhungert ist, hat er das Spiel gewonnen.


Game Over
Ist am Ende des Tages der Hunger auf 0 gesunken, ist das Spiel verloren.
");
            ConsoleUtilities.WaitForKeyPress();
            MyGame.TitleScreen.Run();
        }
    }
}
