using Microsoft.EntityFrameworkCore;
namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=QTS-SimpleBilling;Integrated Security=True");
        }
    }
}
