using Games.API.Models.DTO;
using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(512)]
        public string? Description { get; set; }
        public Uri? Url { get; set; }
        public List<Note> Notes { get; set; }


        public Publisher() { }

        public Publisher(PublisherDto publisherDto)
        {
            if (publisherDto == null)
            {
                throw new ArgumentNullException(nameof(publisherDto), "Developer DTO cannot be null.");
            }
            Name = publisherDto.Name ?? throw new ArgumentNullException(nameof(publisherDto.Name), "Developer name cannot be null.");
            Description = publisherDto.Description;
            Url = publisherDto.Url;
            if (Url != null)
            {
                if (!Uri.IsWellFormedUriString(Url.ToString(), UriKind.Absolute))
                {
                    throw new ArgumentException("Invalid URL format.", nameof(publisherDto));
                }
            }
            Notes = publisherDto.Notes ?? new List<Note>();
        }
    }
}
