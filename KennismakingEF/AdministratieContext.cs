using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennismakingEF
{
    internal class AdministratieContext : DbContext
    {
        public DbSet<Product> Producten { get; set; }
        public DbSet<ProductCategorie> ProductCategorieen { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AdministratieDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductCategorie)
                .WithMany(c => c.Producten)
                .HasForeignKey(p => p.ProductCategorieId);
        }
    }
}
