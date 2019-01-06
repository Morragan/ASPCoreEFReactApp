using Microsoft.EntityFrameworkCore;

namespace Farm_ASPCoreEFReactApp.Models
{
    public class FarmDbContext : DbContext
    {
        public FarmDbContext(DbContextOptions<FarmDbContext> options) : base(options) { }

        public DbSet<Farm> Farms { get; set; }
    }
}
