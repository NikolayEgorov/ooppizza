using pizza.Models;

namespace pizza.ViewModels.Items
{
    public class UpdateViewModels
    {
        public Item item;
        public List<Product> products;

        public UpdateViewModels(Item item, List<Product> products)
        {
            this.item = item;
            this.products = products;
        }
    }
}