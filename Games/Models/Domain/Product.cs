using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(512)]
        public string Name { get; set; }
        public List<Platform> Platforms { get; set; }

        [MaxLength(255)]
        public string? SteamId { get; set; }
        [MaxLength(255)] 
        public string? MobyId { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public PlayStatus PlayStatus { get; set; }
        public DesirabilityTier DesirabilityTier { get; set; }
        public List<Note> Notes { get; set; }
        public List<Uri> Reviews { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Developer> Developers { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

    }
}
