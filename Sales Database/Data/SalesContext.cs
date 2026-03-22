using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_Database.Data
{
    using Microsoft.EntityFrameworkCore;
    using Sales_Database.Models;

    public class SalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=SalesDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
