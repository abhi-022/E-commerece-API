using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Repository
{
    public class EComDbContext: DbContext
    {
        //Dependency Injection
        public EComDbContext(DbContextOptions<EComDbContext> options) : base(options){}

        //DbSets
        public DbSet<Customer> Customers { get; set; }
    }
}
