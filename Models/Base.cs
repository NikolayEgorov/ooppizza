namespace pizza.Models
{
    public class Base 
    {
        public int id { get; set; } = 0;

        public Base() {}

        public Base(int id)
        {
            this.id = id;
        }
    }
}