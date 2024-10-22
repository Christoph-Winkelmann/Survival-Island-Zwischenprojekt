using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZwischenProjekt_CW.ASCII_Art;
using ZwischenProjekt_CW.Scenes;

namespace ZwischenProjekt_CW.UI_OutGame
{
    public static class DisclaimerScene
    {
        public static void ShowDisclaimer()
        {

            Console.Clear();
            Console.WriteLine($"{ASCIIArt.disclaimerArt}");
            Console.WriteLine(@"
Wichtig:
Dies ist eine Projektarbeit. Sie dient als 'Proof-of-Concept' und soll kein vollwertiges Spiel sein.
In diesem Sinne ist das Gameplay sehr schnell repetetiv und bietet nur eine begrenzte Zahl an Features.

Bekannte Probleme:
    +   Derzeit nichts bekannt

Geplante aber nicht implementierte Features:
    +   Event-System
            - Es sollten ursprünglich zufallsbestimmte Events an bestimmten Stellen im Spielverlauf auftauchen können
            - Diese sollten eine zusätzliche Herausforderung bieten.
            - Aus zeitlichen Gründen nicht mit Entwicklung begonnen
    +   Die Höhle
            - Es sollte noch eine sechste Location geben: Das Höhlensystem
            - Dieses sollte alle fünf anderen Locations miteinander verbinden
            - Jede Location hat einen versteckten Eingang, welcher beim Reisen durch ein Zufalls Events hätte entdeckt werden können
            - Die weitere Konzeptionierung dieser Location wurde verworfen, da schnell klar war, dass mir die Zeit nicht reichen würde.
    +   Gefahren
            - Als Teil von Zufalls-Events hätte es Raubtiere, Unwetter oder andere Gefahren geben sollen
            - Unwetter hätten einen Teil der Rohstoffe zerstört, wenn der Spieler kein Shelter gebaut hätte.
            - Raubtiere hätten nachts oder bei der Reise angreifen können. Diese Angriffe hätte man mit dem Speer besser bewältigen können.
    +   Spezial-Fähigkeiten
            - Jede Profession hat eine polymorphe Methode, die sich Special() nennt.
            - Diese ist zwar schon vorhanden, aber ich hatte bisher keine Zeit, mir für jede Profession eine sinnvolle Fähigkeit auszudenken.
            - Deshalb hat keiner eine bekommen.

Jetzt aber viel Spaß mit meinem Spiel :)
");
            ConsoleUtilities.WaitForKeyPress();
        }

    }
}
