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
            optionBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=SimpleBilling1;Integrated Security=True");
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }


    }
}
