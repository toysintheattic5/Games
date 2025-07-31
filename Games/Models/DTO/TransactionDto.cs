using Games.API.Models.Domain;

namespace Games.API.Models.DTO
{
    public class TransactionDto
    {
        public string Product { get; set; }
        public string Date { get; set; }
        public decimal Price { get; set; }
        public string InKind { get; set; }
        public string Entity { get; set; }
        public string Source { get; set; }
        public bool FinalDisposition { get; set; }


        public TransactionDto(Transaction t)
        {
            Product = t.Product.Name;
            Date = t.Date.ToString();
            Price = t.Price;
            InKind = t.InKind;
            Entity = t.Entity.Name;
            Source = t.Source.Name;
            FinalDisposition = t.FinalDisposition;
        }
    }
}
