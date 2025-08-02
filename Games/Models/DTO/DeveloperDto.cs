using Games.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace Games.API.Models.DTO
{
    public class DeveloperDto
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(512)]
        public string? Description { get; set; }
        public Uri? Url { get; set; }
        public List<Note>? Notes { get; set; }


        public DeveloperDto(string name, List<Note> notes, Uri url, string description = "")
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Developer name cannot be null.");
            Notes = notes ?? new List<Note>();
            Description = description;
            Url = url ?? throw new ArgumentNullException(nameof(url), "URL cannot be null.");
            if (!Uri.IsWellFormedUriString(url.ToString(), UriKind.Absolute))
            {
                throw new ArgumentException("Invalid URL format.", nameof(url));
            }
        }

        public DeveloperDto(string name, List<Note> notes, string url = "", string description = "")
        { 
            Name = name ?? throw new ArgumentNullException(nameof(name), "Developer name cannot be null.");
            Notes = notes ?? new List<Note>();
            Description = description;
            if (!string.IsNullOrEmpty(url))
            {
                if (!Uri.TryCreate(url, UriKind.Absolute, out var uriResult) || uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps)
                {
                    throw new ArgumentException("Invalid URL format.", nameof(url));
                }
                Url = uriResult;
            }
        }

        public DeveloperDto(string name, string url = "", string description = "")
            : this(name, new List<Note>(), url, description) { }

        public DeveloperDto(Developer developer)
            : this(developer.Name, developer.Notes, developer.Url, developer.Description ?? "") { }
    }
}
