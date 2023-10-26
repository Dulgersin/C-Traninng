using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Models
{
    public class CrmContext : DbContext
    {
        public CrmContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Check> Checks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CRM2;Username=postgres;Password=4514");
        }
    }
}
