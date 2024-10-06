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
            Boek boek1 = new Boek("978-3-16-148410-0", "C# Basisboek", "Pearson", 29.99m);
            Tijdschrift tijdschrift1 = new Tijdschrift("1234-5678-9101", "Tech Daily", "TechMedia", 5.99m, Verschijningsperiode.Dagelijks);

            Bestelling<Boek> bestellingBoek = new Bestelling<Boek>(boek1, 3);

            bestellingBoek.BoekBesteld += BestellingBoek_BoekBesteld;

            var boekBestelInfo = bestellingBoek.Bestel(boek1);

            Console.WriteLine($"ISBN: {boekBestelInfo.Item1}, Aantal: {boekBestelInfo.Item2}, Totale Prijs: €{boekBestelInfo.Item3}");

            Bestelling<Tijdschrift> bestellingTijdschrift = new Bestelling<Tijdschrift>(tijdschrift1, 12, Verschijningsperiode.Maandelijks);
            Console.WriteLine($"Bestelling voor tijdschrift '{tijdschrift1.Naam}' met {bestellingTijdschrift.Aantal} edities en {bestellingTijdschrift.AbonnementPeriode} abonnement.");
        }

        private static void BestellingBoek_BoekBesteld(object sender, BestellingEventArgs e)
        {
            Console.WriteLine(e.Bericht);
        }
    }
}
