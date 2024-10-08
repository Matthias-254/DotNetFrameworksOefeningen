using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennismakingEF
{
    internal class ProductCategorie
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public List<Product> Producten { get; set; }
    }
}
