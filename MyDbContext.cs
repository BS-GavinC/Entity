using Entity.Configs;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MyDbContext : DbContext
    {
       

        public DbSet<Product> products { get; set; }

        public DbSet<Shop> shops { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-M4I83QU\\SQLEXPRESS;Database=Entity;Trusted_Connection=True;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ShopConfig());
        }
    }
}
