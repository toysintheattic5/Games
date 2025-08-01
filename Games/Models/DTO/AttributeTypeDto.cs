using Games.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.DTO
{
    public class AttributeTypeDto
    {
        public int Id { get; set; }

        [Required, MaxLength(25)]
        public required string Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        public AttributeTypeDto(AttributeType type) 
        {
            if (type == null) throw new ArgumentNullException(nameof(type), "AttributeType cannot be null.");
            Id = type.Id;
            Name = type.Name ?? throw new ArgumentNullException(nameof(type), "AttributeType name cannot be null.");
            Description = type.Description ?? string.Empty; // Default to empty if null+
        }
    }
}
