using Games.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Data
{
    public class GamesDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().Property(p => p.Price).HasPrecision(18, 2);
        }

        public GamesDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<DesirabilityTier> DesirabilityTiers { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlayStatus> PlayStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        internal DbSet<ProductKey> ProductKeys { get; set; }
        public DbSet<SourceEntity> SourceEntities { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Transaction> Transactions { get; set; }



    }
}
