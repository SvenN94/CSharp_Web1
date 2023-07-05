using Microsoft.EntityFrameworkCore;
using MVCSportStore.Models.Data;
using System.Security.Cryptography.X509Certificates;

namespace MVCSportStore.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        { 

        }
        
        public DbSet<Product> Products { get; set; }
        
    }
}
