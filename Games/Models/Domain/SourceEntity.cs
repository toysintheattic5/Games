namespace Games.API.Models.Domain
{
    public class SourceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; }
    }
}
