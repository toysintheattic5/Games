namespace Games.API.Models.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string InKind { get; set; }
        public SourceEntity Entity { get; set; }
        public Source Source { get; set; }
        public bool FinalDisposition { get; set; }


        public Transaction()
        {
            // Default constructor for EF Core
        }

        public Transaction(Product product, Source source, SourceEntity entity, DateTime date, decimal price = 0, string inKind = "", bool finalDisposition = false)
        {
            Product = product;
            Source = source;
            Entity = entity;
            Date = date;
            Price = price;
            InKind = inKind;
            FinalDisposition = finalDisposition;
        }

        public Transaction(Product product, Source source, SourceEntity entity, DateTime date, string inKind = "", bool finalDisposition = false)
            : this(product, source, entity, date, 0, inKind, finalDisposition) { }

        public Transaction(Product product, Source source, SourceEntity entity, DateTime date, decimal price = 0, bool finalDisposition = false)
            : this(product, source, entity, date, price, string.Empty, finalDisposition) { }

        public Transaction(Product product, Source source, SourceEntity entity, string inKind, bool finalDisposition = false)
            : this(product, source, entity, DateTime.Today, 0, inKind, finalDisposition) { }

        public Transaction(Product product, Source source, SourceEntity entity, decimal price, bool finalDisposition = false)
            : this(product, source, entity, DateTime.Today, price, string.Empty, finalDisposition) { }

    }
}