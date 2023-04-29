using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class OrderRepository : IOrders
    {
        protected readonly DatabaseContext dbContext;
        
        public OrderRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Order GetLast() => (Order) this.dbContext.Order.OrderByDescending(o => o.id).Last();
        public Order GetById(int id) => (Order) this.dbContext.Order.Where(o => o.id == id).First();
        public List<Order> All => this.dbContext.Order.ToList();
        
        public Order SaveOne(Order model)
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(int id) {
            this.dbContext.Order.Remove(new Order(id));
            return this.dbContext.SaveChanges() > 0;
        }
    }
}