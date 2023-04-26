using pizza.Models;

namespace pizza.ViewModels.Users {
    public class UpdateViewModels {
        public User user;

        public UpdateViewModels(User user)
        {
            this.user = user;
        }
    }
}