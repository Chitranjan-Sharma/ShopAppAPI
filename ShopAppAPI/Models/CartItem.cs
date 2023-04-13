using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAppAPI.Models
{
    [Table("CartList")]
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ProductId { get; set; }
        public ProductItem? Product { get; set; }

        public int Quantity { get; set; }
    }
}
