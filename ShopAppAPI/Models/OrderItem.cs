using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAppAPI.Models
{

    [Table("OrderList")]
    public class OrderItem
    {
        [Key]
        public int OrderId { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ProductId { get; set; }
        public ProductItem? Product { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPhone { get; set; }

        public string? DeliveryAddress { get; set; }

        public string? OrderStatus { get; set; }

        public string? PaymentMode { get; set; }
    }
}
