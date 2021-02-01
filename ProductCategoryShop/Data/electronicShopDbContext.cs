using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCategoryShop.Models;

namespace ProductCategoryShop.Data
{
    public class electronicShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(cat => cat.Products)
                        .WithOne(pro => pro.Category)
                        .HasForeignKey(pro => pro.CategoryId);


            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = LAPTOP-7LIIO4J8\\WINCC; Database = RobiticiaDb ; Integrated Security = yes ");
            }
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
