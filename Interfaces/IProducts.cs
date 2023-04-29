using pizza.Models;

namespace pizza.Interfaces
{
    public interface IProducts
    {
        public Product GetLast();
        public Product GetById(int id);
        public Product SaveOne(Product product);
        public List<Product> All { get; }
        public bool RemoveById(int id);     
    }

}