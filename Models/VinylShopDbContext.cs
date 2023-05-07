using Microsoft.EntityFrameworkCore;

namespace VinylShop.Models
{
    public class VinylShopDbContext : DbContext
    {
        public VinylShopDbContext() { }
        public VinylShopDbContext(DbContextOptions<VinylShopDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VinylShop;Trusted_Connection=True;User Id=vladm;Password=");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Vinyl> Vinyls { get; set; }
    }
}
