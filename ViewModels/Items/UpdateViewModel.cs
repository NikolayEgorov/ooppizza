using pizza.Models;

namespace pizza.ViewModels.Items {
    public class UpdateViewModels {
        public Item item;

        public UpdateViewModels(Item item)
        {
            this.item = item;
        }
    }
}