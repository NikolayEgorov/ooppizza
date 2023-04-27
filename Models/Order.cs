namespace pizza.Models
{
    public class Order : Base
    {
        public Order(int id) : base(id) {}

        public List<Item> items { get; set; }
        public User user { get; set; }
    }
}