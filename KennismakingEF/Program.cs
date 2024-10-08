using Microsoft.EntityFrameworkCore;

namespace KennismakingEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AdministratieContext())
            {
                context.Database.Migrate();

                if (!context.ProductCategorieen.Any())
                {
                    var categorie1 = new ProductCategorie { Naam = "Elektronica" };
                    var categorie2 = new ProductCategorie { Naam = "Boeken" };

                    context.ProductCategorieen.AddRange(categorie1, categorie2);
                    context.SaveChanges();
                }

                if (!context.Producten.Any())
                {
                    var producten = new[]
                    {
                    new Product { Naam = "Laptop", Omschrijving = "Een snelle laptop", ProductCategorieId = 1 },
                    new Product { Naam = "Telefoon", Omschrijving = "Een moderne smartphone", ProductCategorieId = 1 },
                    new Product { Naam = "C# Programming", Omschrijving = "Boek over C# programmeertaal", ProductCategorieId = 2 }
                };

                    context.Producten.AddRange(producten);
                    context.SaveChanges();
                }

                var productenMetCategorie = context.Producten
                    .Include(p => p.ProductCategorie)
                    .ToList();

                foreach (var product in productenMetCategorie)
                {
                    Console.WriteLine($"Product: {product.Naam}, Omschrijving: {product.Omschrijving}, Categorie: {product.ProductCategorie.Naam}");
                }
            }
        }
    }
}