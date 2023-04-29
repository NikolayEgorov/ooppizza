using pizza.Enums;
using pizza.Models;

namespace pizza.ViewModels.Users {
    public class IndexViewModels {
        public IEnumerable<User> users;

        public IndexViewModels(IEnumerable<User> users)
        {
            this.users = users;
        }
    }
}