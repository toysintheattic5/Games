using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Games.API.Models.Domain
{
    public class ProductKey
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Code { get; set; }
        public bool Redeemed { get; set; }
        public bool Exposed { get; set; }
    }
}
