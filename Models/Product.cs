namespace pizza.Models
{
    public class Product : Base
    {
        public Product(int id) : base(id) {}

        public string title { get; set; }
        public List<Item> items { get; set; }
    }
}