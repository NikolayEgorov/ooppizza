using pizza.Enums;
using pizza.Models;

namespace pizza.ViewModels.Items {
    public class IndexViewModels {
        public IEnumerable<Item> items;

        public IndexViewModels(IEnumerable<Item> items)
        {
            this.items = items;
        }
    }
}