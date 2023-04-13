using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAppAPI.Models
{
    [Table("UserList")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
