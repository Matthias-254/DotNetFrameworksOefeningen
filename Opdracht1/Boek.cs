﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek
    {
        public string Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        private decimal prijs;
        public decimal Prijs
        {
            get { return prijs; }
            set
            {
                if (value < 5)
                    prijs = 5;
                else if (value > 50)
                    prijs = 50;
                else
                    prijs = value;
            }
        }

        public Boek(string isbn, string naam, string uitgever, decimal prijs)
        {
            Isbn = isbn;
            Naam = naam;
            Uitgever = uitgever;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"Boek: {Naam}, ISBN: {Isbn}, Uitgever: {Uitgever}, Prijs: €{Prijs}";
        }

        public void Lees()
        {
            Console.WriteLine("Geef de ISBN in:");
            Isbn = Console.ReadLine();

            Console.WriteLine("Geef de naam van het boek in:");
            Naam = Console.ReadLine();

            Console.WriteLine("Geef de uitgever in:");
            Uitgever = Console.ReadLine();

            Console.WriteLine("Geef de prijs in:");
            Prijs = decimal.Parse(Console.ReadLine());
        }
    }
}
