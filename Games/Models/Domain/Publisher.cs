using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public required string Name { get; set; }
        [MaxLength(512)]
        public string? Description { get; set; }
        public Uri? Url { get; set; }
        public List<Note> Notes { get; set; }
    }
}
