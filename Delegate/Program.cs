namespace Delegate
{

    public delegate void AlarmOptie();

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--->Wekker Instellen<--->");
            Console.WriteLine();

            char keuze = ' ';

            do
            {
                Console.WriteLine("-*-Wekker Instellingen Menu-*-");
                Console.WriteLine("T voor de tijd dat je gewekt wil worden in te stellen.");
                Console.WriteLine("S voor sluimertijd in te stellen.");
                Console.WriteLine("A om alarm te stoppen en sluimer te laten lopen.");
                Console.WriteLine("M Om in te stellen op welke manier je gewekt wil worden.");
                Console.WriteLine("Q om te stoppen.");
                Console.Write("keuze: ");
                keuze = Console.ReadLine().ToUpper()[0];
                Console.WriteLine();

                AlarmOptie alarmOptie = null;

                switch (keuze)
                {
                    case 'T':
                        alarmOptie = TijdInstellenMenu;
                        break;
                    case 'S':
                        alarmOptie = SluimertijdMenu;
                        break;
                    case 'A':
                        alarmOptie = AlarmMenu;
                        break;
                    case 'M':
                        alarmOptie = WekMethodeMenu;
                        break;
                    case 'Q':
                        Console.WriteLine("Programma wordt afgesloten...");
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.\n");
                        break;
                }

                if (alarmOptie != null)
                {
                    alarmOptie();
                }

            } while (keuze != 'Q');
        }

        static void TijdInstellenMenu()
        {
            Console.WriteLine("Tijd dat u gewekt wil worden:");
            string keuze = Console.ReadLine();
            Console.WriteLine($"Wekker gaat af om {keuze}\n");
        }

        static void SluimertijdMenu()
        {
            Console.WriteLine("Lengte sluimertijd (in minuten):");
            string keuze = Console.ReadLine();
            Console.WriteLine($"De sluimertijd staat ingesteld op {keuze} minuten.\n");
        }

        static void AlarmMenu()
        {
            Console.Write("Druk enter om de snooze te starten: ");
            string wacht = Console.ReadLine();
            Console.WriteLine("Snooze gestart.\n");
        }

        static void WekMethodeMenu()
        {
            Console.WriteLine("Manier van wekken:");
            Console.WriteLine("1. Standaard alarmgeluid");
            Console.WriteLine("2. Rustige muziek");
            Console.WriteLine("3. Luide pieptoon");
            Console.Write("Keuze: ");
            string keuze = Console.ReadLine();
            Console.WriteLine($"Wekmethode {keuze} gekozen.\n");
        }

        //Laatste test
    }
}
