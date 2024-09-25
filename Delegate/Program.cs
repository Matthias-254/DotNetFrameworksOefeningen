namespace Delegate
{
    delegate void Alarm();

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
                Console.WriteLine(keuze + "\n");

            } while (true);
        }
    }
}
