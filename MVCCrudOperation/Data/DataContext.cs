using Microsoft.EntityFrameworkCore;
using MVCCrudOperation.Models;

namespace MVCCrudOperation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
