using pizza.Models;

namespace pizza.Interfaces
{
    public interface IBase
    {
        public Base GetLast();
        public Base GetById(int id);
        public Base SaveOne(Base model);
        public bool RemoveById(int id);
        public IEnumerable<Base> All { get; }
    }
}