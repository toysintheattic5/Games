using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Developer
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Url { get; set; }
        public bool IsDeveloper { get; set; }
        public bool IsPublisher { get; set; }
        public List<Note> Notes { get; set; }
    }
}
