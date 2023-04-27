using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class OrderRepository : BaseRepository, IOrders
    {
        public OrderRepository(DatabaseContext dbContext) : base(dbContext) {}

        public override Order GetLast() => (Order) this.dbContext.Order.OrderByDescending(o => o.id).Last();
        public override Order GetById(int id) => (Order) this.dbContext.Order.Where(o => o.id == id).First();

        public override bool RemoveById(int id) {
            this.dbContext.Order.Remove(new Order(id));
            return this.dbContext.SaveChanges() > 0;
        }

        public override IEnumerable<Order> All => (List<Order>) this.dbContext.Order.Where(o => o.id > 0);
    }
}