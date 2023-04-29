using pizza.Models;

namespace pizza.Interfaces
{
    public interface IOrders
    {
        public Order GetLast();
        public Order GetById(int id);
        public Order SaveOne(Order model);
        public List<Order> All { get; }
        public bool RemoveById(int id); 
    }
}