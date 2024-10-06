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
            // Twee Boeken
            Boek boek1 = new Boek("978-3-16-148410-0", "C# Basisboek", "Pearson", 29.99m);
            Boek boek2 = new Boek("978-0-12-345678-9", "Geavanceerde C#", "Packt", 39.99m);

            // Twee Tijdschriften
            Tijdschrift tijdschrift1 = new Tijdschrift("1234-5678-9101", "Tech Daily", "TechMedia", 5.99m, Verschijningsperiode.Dagelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("2345-6789-1011", "Science Weekly", "ScienceHub", 3.99m, Verschijningsperiode.Wekelijks);

            // Weergave van de Boeken
            Console.WriteLine(boek1.ToString());
            Console.WriteLine(boek2.ToString());

            // Weergave van de Tijdschriften
            Console.WriteLine(tijdschrift1.ToString());
            Console.WriteLine(tijdschrift2.ToString());

            // Gebruik van de Lees-methode om een Tijdschrift interactief aan te maken
            Tijdschrift tijdschrift3 = new Tijdschrift("", "", "", 0, Verschijningsperiode.Maandelijks);
            tijdschrift3.Lees();
            Console.WriteLine(tijdschrift3.ToString());
        }
    }
}
