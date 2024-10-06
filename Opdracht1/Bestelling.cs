using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    internal class Bestelling<T>
    {
        private static int laatsteId = 0;

        public int Id { get; private set; }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public Verschijningsperiode? AbonnementPeriode { get; set; }

        public Bestelling(T item, int aantal, Verschijningsperiode? periode = null)
        {
            Id = ++laatsteId;
            Item = item;
            Datum = DateTime.Now;
            Aantal = aantal;
            AbonnementPeriode = periode;
        }

        public Tuple<string, int, double> Bestel(Boek boek)
        {
            double totalePrijs = boek.Prijs * Aantal;

            OnBoekBesteld(new BestellingEventArgs($"Bestelling voor boek '{boek.Naam}' is geplaatst."));

            return new Tuple<string, int, double>(boek.Isbn, Aantal, totalePrijs);
        }

        public event EventHandler<BestellingEventArgs> BoekBesteld;

        protected void OnBoekBesteld(BestellingEventArgs e)
        {
            if (BoekBesteld != null)
            {
                BoekBesteld(this, e);
            }
        }
    }

    public class BestellingEventArgs : EventArgs
    {
        public string Bericht { get; private set; }

        public BestellingEventArgs(string bericht)
        {
            Bericht = bericht;
        }
    }
}
