using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Note
    {
        public int Id { get; set; }

        [MaxLength(2048)]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
