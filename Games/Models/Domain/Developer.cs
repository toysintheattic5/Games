using Games.API.Models.DTO;
using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Developer
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(512)]
        public string? Description { get; set; }
        public Uri? Url { get; set; }
        public List<Note> Notes { get; set; }


        public Developer() { }

        public Developer(DeveloperDto developerDto)
        {
            if (developerDto == null)
            {
                throw new ArgumentNullException(nameof(developerDto), "Developer DTO cannot be null.");
            }
            Name = developerDto.Name ?? throw new ArgumentNullException(nameof(developerDto.Name), "Developer name cannot be null.");
            Description = developerDto.Description;
            Url = developerDto.Url;
            if (Url != null)
            {
                if (!Uri.IsWellFormedUriString(Url.ToString(), UriKind.Absolute))
                {
                    throw new ArgumentException("Invalid URL format.", nameof(developerDto));
                }
            }   
            Notes = developerDto.Notes ?? new List<Note>();
        }
    }
}
