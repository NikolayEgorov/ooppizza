using pizza.Models;
using pizza.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace pizza.Repositories
{
    public class UserRepository : BaseRepository, IUsers
    {
        public UserRepository(DatabaseContext dbContext) : base(dbContext) {}

        public override User GetLast() => (User) this.dbContext.User.OrderByDescending(u => u.id).Last();
        public override User GetById(int id) => (User) this.dbContext.User.Where(u => u.id == id).First();
        
        public override bool RemoveById(int id) {
            this.dbContext.User.Remove(new User(id));
            return this.dbContext.SaveChanges() > 0;
        }

        public override IEnumerable<User> All => (List<User>) this.dbContext.User.ToList();
    }
}