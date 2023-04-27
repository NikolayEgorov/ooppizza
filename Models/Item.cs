namespace pizza.Models
{
    public class Item : Base
    {
        public Item(int id) : base(id) {}

        public string title { get; set; }
        public int price { get; set; }
        public List<Product> products { get; set; }
    }
}