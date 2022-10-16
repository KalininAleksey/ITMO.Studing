using System.Data.Entity;

namespace ITMO.Studing.ADO.Lab9.CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
