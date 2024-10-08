﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Tijdschrift : Boek
    {
        public Verschijningsperiode Periode { get; set; }

        public Tijdschrift(string isbn, string naam, string uitgever, double prijs, Verschijningsperiode periode)
            : base(isbn, naam, uitgever, prijs)
        {
            Periode = periode;
        }

        public override string ToString()
        {
            return base.ToString() + $", Verschijningsperiode: {Periode}";
        }

        public new void Lees()
        {
            base.Lees();

            Console.WriteLine("Geef de verschijningsperiode in (0 = Dagelijks, 1 = Wekelijks, 2 = Maandelijks):");
            int keuze = int.Parse(Console.ReadLine());
            Periode = (Verschijningsperiode)keuze;
        }
    }
}
