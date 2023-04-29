using pizza.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizza.Models
{
    public class Product : Base
    { 
        public string title { get; set; } = String.Empty;
        public List<ItemProduct> itemProducts { get; set; } = new List<ItemProduct>();
        public List<Item> items { get; set; } = new List<Item>();

        public Product() {}
    }
}