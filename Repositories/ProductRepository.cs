using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class ProductRepository : BaseRepository, IProducts
    {
        public ProductRepository(DatabaseContext dbContext) : base(dbContext) {}

        public override Product GetLast() => (Product) this.dbContext.Product.OrderByDescending(p => p.id).Last();
        public override Product GetById(int id) => (Product) this.dbContext.Product.Where(p => p.id == id).First();

        public override bool RemoveById(int id) {
            this.dbContext.Product.Remove(new Product(id));
            return this.dbContext.SaveChanges() > 0;
        }

        public override IEnumerable<Product> All => (List<Product>) this.dbContext.Product.Where(p => p.id > 0);
    }
}