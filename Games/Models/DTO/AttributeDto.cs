using Games.API.Models.Domain;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Models.DTO
{
    public class AttributeDto
    {
        public string Name { get; }
        public virtual AttributeType AttributeType { get; set; }


        public AttributeDto(Attribute a)
        {
            Name = a.Name;
            AttributeType = a.AttributeType;
        }

        public AttributeDto(AttributeTypeEnum attributeType, string name)
        {
            Name = name;
            AttributeType = attributeType;
        }

        public AttributeDto(string type, string name, string description = "")
            : this((AttributeTypeEnum)Enum.Parse(typeof(AttributeTypeEnum), type), name) { }
    }
}
