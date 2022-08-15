using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Configuration;

namespace mySmartWallet2022.Models.Data.Entities
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }
        
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         customerConfiguration.Build(modelBuilder);
         base.OnModelCreating(modelBuilder); 
        }
    }
}
 