using Games.API.Models.Application;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.API.Models.Domain
{
    public class AttributeType
    {
        private AttributeType(AttributeTypeEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }


        protected AttributeType() { } //For EF


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Id { get; set; }
        [Required, MaxLength(25)] 
        public string Name { get; set; }
        [MaxLength(100)] 
        public string Description { get; set; }


        public static implicit operator AttributeType(AttributeTypeEnum @enum) => new AttributeType(@enum);

        public static implicit operator AttributeTypeEnum(AttributeType attributeType) => (AttributeTypeEnum)attributeType.Id;
    }


    public enum AttributeTypeEnum
    {
        [Description("Genre")]
        Genre = 0,
        [Description("Perspective")]
        Perspective,
        [Description("Setting")]
        Setting,
        [Description("General Tag")]
        GeneralTag
    }
}
