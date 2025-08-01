using Games.API.Models.Domain;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Models.DTO
{
    public class AttributeDto
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }

        [Required]
        public virtual AttributeType AttributeType { get; set; }


        public AttributeDto(string name, AttributeTypeEnum attributeType)
        {
            if (name.IsNullOrEmpty()) throw new ArgumentNullException("Attribute name is required.");
            if (!Enum.IsDefined(typeof(AttributeTypeEnum), attributeType))
                throw new ArgumentException("Invalid attribute type.");

            Name = name;
            AttributeType = attributeType;
        }

        public AttributeDto(string name, string type, string description = "")
            : this(name, (AttributeTypeEnum)Enum.Parse(typeof(AttributeTypeEnum), type)) { }

        public AttributeDto(Attribute a) : this(a.Name, a.AttributeType) 
        {
            Id = a.Id;
        }

    }
}
