namespace pizza.Models
{
    public class Order : Base
    {
        public List<Item> items { get; set; } = new List<Item>();
        public User user { get; set; } = new User(0);
        public Order(int id) : base(id) {}
    }
}