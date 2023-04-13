using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAppAPI.Models;

namespace ShopAppAPI.Data
{
    public class ShopAppDbContext : DbContext
    {
        public ShopAppDbContext (DbContextOptions<ShopAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShopAppAPI.Models.User> User { get; set; } = default!;

        public DbSet<ShopAppAPI.Models.ProductItem>? Product { get; set; }

        public DbSet<ShopAppAPI.Models.CartItem>? Cart { get; set; }

        public DbSet<ShopAppAPI.Models.OrderItem>? OrderItem { get; set; }
    }
}
