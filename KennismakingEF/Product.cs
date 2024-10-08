using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennismakingEF
{
    class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int ProductCategorieId { get; set; }
        public ProductCategorie ProductCategorie { get; set; }
    }
}
