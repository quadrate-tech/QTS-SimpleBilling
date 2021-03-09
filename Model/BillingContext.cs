using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<SellingPrice> SellingPrices { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=QTS_SimpleBilling;Integrated Security=True");
        }
    }
}
