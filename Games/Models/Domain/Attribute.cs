using Games.API.Models.DTO;
using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Attribute
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public virtual AttributeType AttributeType { get; set; }


        public Attribute() { }

        public Attribute(string name, AttributeTypeEnum attributeType)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name), "Attribute name is required.");
            if (!Enum.IsDefined(typeof(AttributeTypeEnum), attributeType))
                throw new ArgumentException("Invalid attribute type.", nameof(attributeType));
            Name = name;
            AttributeType = attributeType;
        }

        public Attribute(AttributeDto attributeDto)
        {
            if (attributeDto == null) throw new ArgumentNullException(nameof(attributeDto), "Attribute DTO cannot be null.");
            if (string.IsNullOrEmpty(attributeDto.Name)) throw new ArgumentNullException(nameof(attributeDto), "Attribute name is required.");
            if (!Enum.IsDefined(typeof(AttributeTypeEnum), attributeDto.AttributeType))
                throw new ArgumentException("Invalid attribute type.", nameof(attributeDto.AttributeType));
            Id = attributeDto.Id;
            Name = attributeDto.Name;
            AttributeType = attributeDto.AttributeType;
        }
    }
}