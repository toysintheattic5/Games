using Games.API.Data;
using Games.API.Models.Domain;
using Games.API.Models.Application;

namespace Games.API
{
    public class Configuration
    {
        public const string Version = "0.1.0";
        public const string Name = "Games API";
        public const string Description = "A RESTful API for managing games, attributes, and categories.";
        public const string Author = "Your Name";
        public const string ContactEmail = "";

        //protected override void Seed(GamesDbContext context)
        //{
        //    // Seed PlayStatusEnum values
        //    context.PlayStatuses.SeedEnumValues<PlayStatus, PlayStatusEnum>(e => e);
        //    // Seed DesirabilityTierEnum values
        //    context.DesirabilityTiers.SeedEnumValues<DesirabilityTier, DesirabilityTierEnum>(e => e);
        //    // Seed AttributeTypeEnum values
        //    context.AttributeTypes.SeedEnumValues<AttributeType, AttributeTypeEnum>(e => e);
            
        //    context.SaveChanges();
        //}
    }
}
