namespace Omkeren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Kies een methode om de string om te keren:");
                Console.WriteLine("1. For-loop");
                Console.WriteLine("2. While-loop");
                Console.WriteLine("3. Do-while-loop");
                Console.WriteLine("4. Recursie");
                Console.WriteLine("5. Afsluiten");

                string keuze = Console.ReadLine();

                if (keuze == "5")
                {
                    Console.WriteLine("Programma afgesloten.");
                    break;
                }

                Console.WriteLine("Voer een string in om om te keren:");
                string input = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Omgekeerd met for-loop: " + OmkerenMetForLoop(input));
                        break;
                    case "2":
                        Console.WriteLine("Omgekeerd met while-loop: " + OmkerenMetWhileLoop(input));
                        break;
                    case "3":
                        Console.WriteLine("Omgekeerd met do-while-loop: " + OmkerenMetDoWhileLoop(input));
                        break;
                    case "4":
                        Console.WriteLine("Omgekeerd met recursie: " + OmkerenMetRecursie(input));
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        break;
                }

                Console.WriteLine();
            }
        }
        static string OmkerenMetForLoop(string input)
        {
            char[] omgekeerd = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                omgekeerd[i] = input[input.Length - 1 - i];
            }
            return new string(omgekeerd);
        }

        static string OmkerenMetWhileLoop(string input)
        {
            char[] omgekeerd = new char[input.Length];
            int i = 0;
            while (i < input.Length)
            {
                omgekeerd[i] = input[input.Length - 1 - i];
                i++;
            }
            return new string(omgekeerd);
        }

        static string OmkerenMetDoWhileLoop(string input)
        {
            if (input.Length == 0) return input;

            char[] omgekeerd = new char[input.Length];
            int i = 0;
            do
            {
                omgekeerd[i] = input[input.Length - 1 - i];
                i++;
            } while (i < input.Length);
            return new string(omgekeerd);
        }

        static string OmkerenMetRecursie(string input)
        {
            if (input.Length <= 1)
                return input;
            return OmkerenMetRecursie(input.Substring(1)) + input[0];
        }
    }
}
