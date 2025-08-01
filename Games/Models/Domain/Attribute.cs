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

    }

}
