namespace nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer de naam van de werknemer in: ");
            string naam = Console.ReadLine();

            int? jarenVerkoop = VraagAantalJaren("Verkoop");

            int? jarenOndersteuning = VraagAantalJaren("Ondersteuning");

            int? jarenAdministratie = VraagAantalJaren("Administratie");

            int aantalAfdelingenGewerkt = 0;

            if (jarenVerkoop.HasValue && jarenVerkoop > 0) aantalAfdelingenGewerkt++;
            if (jarenOndersteuning.HasValue && jarenOndersteuning > 0) aantalAfdelingenGewerkt++;
            if (jarenAdministratie.HasValue && jarenAdministratie > 0) aantalAfdelingenGewerkt++;

            if (aantalAfdelingenGewerkt >= 2)
            {
                int totaalJarenInDienst = (jarenVerkoop ?? 0) + (jarenOndersteuning ?? 0) + (jarenAdministratie ?? 0);
                int bonusPercentage = totaalJarenInDienst * 2;
                Console.WriteLine($"{naam} heeft gewerkt in minstens 2 afdelingen en heeft recht op een bonus van {bonusPercentage}%.");
            }
            else
            {
                Console.WriteLine($"{naam} heeft niet in genoeg afdelingen gewerkt om een bonus te ontvangen.");
            }
        }
        static int? VraagAantalJaren(string afdelingNaam)
        {
            while (true)
            {
                Console.Write($"Hoeveel jaren heeft de werknemer in {afdelingNaam} gewerkt? (voer niets in als niet van toepassing): ");
                string invoer = Console.ReadLine();

                if (string.IsNullOrEmpty(invoer))
                {
                    return null;
                }

                if (int.TryParse(invoer, out int jaren) && jaren >= 0)
                {
                    return jaren;
                }

                Console.WriteLine("Ongeldige invoer. Voer een geldig positief aantal jaren in.");
            }
        }
    }   
}
