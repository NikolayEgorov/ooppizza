using pizza.Models;

namespace pizza.ViewModels.Orders
{
    public class UpdateViewModels
    {
        public Order order;
        public List<User> users;

        public UpdateViewModels(Order order, List<User> users)
        {
            this.order = order;
            this.users = users;
        }
    }
}