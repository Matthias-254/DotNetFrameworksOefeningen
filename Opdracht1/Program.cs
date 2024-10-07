namespace Opdracht1
{
    public enum Verschijningsperiode
    {
        Dagelijks,
        Wekelijks,
        Maandelijks
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8; // Om het euroteken weer te geven

            Boek boek1 = new Boek("978-3-16-148410-0", "C# Basisboek", "Pearson", 29.99);
            Boek boek2 = new Boek("978-1-23-456789-0", "Java voor Beginners", "O'Reilly", 39.99);

            Tijdschrift tijdschrift1 = new Tijdschrift("1234-5678-9101", "Tech Daily", "TechMedia", 5.99, Verschijningsperiode.Dagelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("2345-6789-1011", "Science Weekly", "ScienceWorld", 9.99, Verschijningsperiode.Wekelijks);

            Console.WriteLine("Aangemaakte boeken:");
            Console.WriteLine(boek1.ToString());
            Console.WriteLine(boek2.ToString());

            Console.WriteLine("\nAangemaakte tijdschriften:");
            Console.WriteLine(tijdschrift1.ToString());
            Console.WriteLine(tijdschrift2.ToString());

            Console.WriteLine("\nWil je een Boek (1) of Tijdschrift (2) aanmaken?");
            string keuze = Console.ReadLine();

            if (keuze == "1")
            {
                Boek nieuwBoek = new Boek("", "", "", 0);
                nieuwBoek.Lees();

                Console.WriteLine("\nIngevoerde Boek:");
                Console.WriteLine(nieuwBoek.ToString());

                Console.WriteLine("\nGeef het aantal exemplaren dat je wilt bestellen:");
                int aantal = int.Parse(Console.ReadLine());
                Bestelling<Boek> bestellingBoek = new Bestelling<Boek>(nieuwBoek, aantal);

                bestellingBoek.BoekBesteld += BestellingBoek_BoekBesteld;

                var boekBestelInfo = bestellingBoek.Bestel(nieuwBoek);

                Console.WriteLine($"\nBestelling geplaatst: ISBN: {boekBestelInfo.Item1}, Aantal: {boekBestelInfo.Item2}, Totale Prijs: €{boekBestelInfo.Item3}");
            }
            else if (keuze == "2")
            {
                Tijdschrift nieuwTijdschrift = new Tijdschrift("", "", "", 0, Verschijningsperiode.Dagelijks);
                nieuwTijdschrift.Lees();

                Console.WriteLine("\nIngevoerde Tijdschrift:");
                Console.WriteLine(nieuwTijdschrift.ToString());

                Console.WriteLine("\nGeef het aantal edities dat je wilt bestellen:");
                int aantal = int.Parse(Console.ReadLine());

                Console.WriteLine("Geef de verschijningsperiode voor het abonnement (0 = Dagelijks, 1 = Wekelijks, 2 = Maandelijks):");
                Verschijningsperiode periode = (Verschijningsperiode)int.Parse(Console.ReadLine());

                Bestelling<Tijdschrift> bestellingTijdschrift = new Bestelling<Tijdschrift>(nieuwTijdschrift, aantal, periode);

                Console.WriteLine($"\nBestelling geplaatst: Tijdschrift '{nieuwTijdschrift.Naam}', Aantal: {bestellingTijdschrift.Aantal}, Abonnement: {bestellingTijdschrift.AbonnementPeriode}");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            }
        }

        private static void BestellingBoek_BoekBesteld(object sender, BestellingEventArgs e)
        {
            Console.WriteLine(e.Bericht);
        }
    }
}
