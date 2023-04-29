using pizza.Models;

namespace pizza.ViewModels.Orders
{
    public class UpdateViewModels
    {
        public Order order;
        public List<User> users;
        public List<Item> items;

        public UpdateViewModels(Order order, List<Item> items, List<User> users)
        {
            this.order = order;
            this.items = items;
            this.users = users;
        }
    }
}