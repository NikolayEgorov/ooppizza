using pizza.Models;
using Microsoft.EntityFrameworkCore;

namespace pizza
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) {}

        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}