using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class ItemRepository : BaseRepository, IItems
    {
        public ItemRepository(DatabaseContext dbContext) : base(dbContext) {}

        public override Item GetLast() => (Item) this.dbContext.Item.OrderByDescending(i => i.id).Last();
        public override Item GetById(int id) => (Item) this.dbContext.Item.Where(i => i.id == id).First();

        public override bool RemoveById(int id) {
            this.dbContext.Item.Remove(new Item(id));
            return this.dbContext.SaveChanges() > 0;
        }

        public override IEnumerable<Item> All => (List<Item>) this.dbContext.Item.Where(i => i.id > 0);
    }
}