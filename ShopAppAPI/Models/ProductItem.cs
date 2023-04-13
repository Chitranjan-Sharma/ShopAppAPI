using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAppAPI.Models
{
    [Table("ProductList")]
    public class ProductItem
    {
        [Key]
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? BrandName { get; set; }

        public string? Category { get; set; }

        public string? ImageUrl { get; set; }

        public double Price { get; set; }

        public int Rating { get; set; }

        public string? Description { get; set; }
    }
}
