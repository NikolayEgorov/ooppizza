using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class UserRepository : IUsers
    {
        protected readonly DatabaseContext dbContext;
        
        public UserRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetLast() => this.dbContext.User.OrderByDescending(u => u.id).Last();
        public User GetById(int id) => this.dbContext.User.Where(u => u.id == id).First();
        public List<User> All => this.dbContext.User.ToList();

        public User SaveOne(User user)
        {
            return new User(0);
        }
        
        public bool RemoveById(int id)
        {
            this.dbContext.User.Remove(new User(id));
            return this.dbContext.SaveChanges() > 0;
        }
    }
}