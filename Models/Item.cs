namespace pizza.Models
{
    public class Item : Base
    {
        public string title { get; set; } = String.Empty;
        public int price { get; set; } = 0;
        public List<ItemProduct> itemProducts { get; set; } = new List<ItemProduct>();
        public List<Product> products { get; set; } = new List<Product>();

        public Item() {}
        public Item(int id) : base(id) {}
    }
}