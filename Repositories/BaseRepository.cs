using pizza.Interfaces;
using pizza.Models;

namespace pizza.Repositories
{
    abstract public class BaseRepository : IBase
    {
        protected readonly DatabaseContext dbContext;

        public BaseRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        abstract public Base GetById(int id);
        abstract public Base GetLast();
        abstract public bool RemoveById(int id);

        public Base SaveOne(Base model)
        {
            this.dbContext.Add(model);
            bool status = this.dbContext.SaveChanges() > 0 ? true : false;
            
            return status ? this.GetLast() : null;
        }

        abstract public IEnumerable<Base> All { get; }
    }
}