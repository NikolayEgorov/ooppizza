using Microsoft.EntityFrameworkCore;

namespace pizza
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        
        }
    }
}