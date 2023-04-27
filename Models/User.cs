namespace pizza.Models
{
    public class User : Base
    {
        public string name { get; set; }
        public string surname { get; set; }
        public List<Order> orders { get; set; }

        public User(int id) : base(id) {}
    }
}