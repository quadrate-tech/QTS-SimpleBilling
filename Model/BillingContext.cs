using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=LAPTOP-DM8ANEE6\SQLEXPRESS;Initial Catalog=billing;Integrated Security=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ReceiptBody> ReceiptBodies { get; set; }
        public DbSet<ReceiptHeader> ReceiptHeaders { get; set; }
    }
}

