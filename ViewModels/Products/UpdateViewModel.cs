using pizza.Models;

namespace pizza.ViewModels.Products {
    public class UpdateViewModels {
        public Product product;

        public UpdateViewModels(Product product)
        {
            this.product = product;
        }
    }
}