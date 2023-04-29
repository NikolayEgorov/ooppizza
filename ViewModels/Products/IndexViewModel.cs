using pizza.Enums;
using pizza.Models;

namespace pizza.ViewModels.Products {
    public class IndexViewModels {
        public IEnumerable<Product> products;

        public IndexViewModels(IEnumerable<Product> products)
        {
            this.products = products;
        }
    }
}