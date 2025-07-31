namespace Games.API.Models.Domain
{
    /// <summary>
    /// How a product was acquired, such as through a store, a giveaway, or a trade.
    /// </summary>
    public class Source
    {
        public int Id { get; set; }
        public SourceType Type { get; set; }
        public string Name => Type.ToString();
    }

    public enum SourceType
    {
        Purchase,
        Giveaway,
        MassGiveaway,
        Trade,
        CrowdFunding,
        Other
    }
}
