using Microsoft.EntityFrameworkCore;
using RedisCacheSample.Controllers;

namespace RedisCacheSample
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}