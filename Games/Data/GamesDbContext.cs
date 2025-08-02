using Games.API.Models.Application;
using Games.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Data
{
    public class GamesDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().Property(p => p.Price).HasPrecision(18, 2);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(@"Server=ROGER-NONPC\\SQLEXPRESS;Database=GAMES_EF;Trusted_Connection=True;TrustServerCertificate=True")
                .UseSeeding((context, _) =>
                {
                    Enum.GetValues(typeof(AttributeTypeEnum))
                                   .Cast<object>()
                                   .Select(value => (AttributeTypeEnum)value)
                                   .ToList()
                                   .ForEach(instance => AttributeTypes.Add(instance));
                    Enum.GetValues(typeof(PlayStatusEnum))
                                   .Cast<object>()
                                   .Select(value => (PlayStatusEnum)value)
                                   .ToList()
                                   .ForEach(instance => PlayStatuses.Add(instance));
                    Enum.GetValues(typeof(DesirabilityTierEnum))
                                   .Cast<object>()
                                   .Select(value => (DesirabilityTierEnum)value)
                                   .ToList()
                                   .ForEach(instance => DesirabilityTiers.Add(instance));
                    context.SaveChanges();
                })
                .UseAsyncSeeding(async (context, _, cancellationToken) =>
                {
                    Enum.GetValues(typeof(AttributeTypeEnum))
                                   .Cast<object>()
                                   .Select(value => (AttributeTypeEnum)value)
                                   .ToList()
                                   .ForEach(instance => AttributeTypes.Add(instance));
                    Enum.GetValues(typeof(PlayStatusEnum))
                                   .Cast<object>()
                                   .Select(value => (PlayStatusEnum)value)
                                   .ToList()
                                   .ForEach(instance => PlayStatuses.Add(instance));
                    Enum.GetValues(typeof(DesirabilityTierEnum))
                                   .Cast<object>()
                                   .Select(value => (DesirabilityTierEnum)value)
                                   .ToList()
                                   .ForEach(instance => DesirabilityTiers.Add(instance));
                    await context.SaveChangesAsync();
                });


        public GamesDbContext(DbContextOptions<GamesDbContext> options) : base(options) { }


        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<DesirabilityTier> DesirabilityTiers { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlayStatus> PlayStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        internal DbSet<ProductKey> ProductKeys { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SourceEntity> SourceEntities { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Transaction> Transactions { get; set; }



    }
}
