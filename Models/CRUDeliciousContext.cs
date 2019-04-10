using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicious.Models
{
    public class CRUDeliciousContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CRUDeliciousContext(DbContextOptions options) : base(options) { }

        public DbSet<Dishes> dishes {get;set;}
    }
}
