using pizza.Models;

namespace pizza.ViewModels.Orders
{
    public class IndexViewModels
    {
        public IEnumerable<Order> orders;

        public IndexViewModels(IEnumerable<Order> orders)
        {
            this.orders = orders;
        }
    }
}