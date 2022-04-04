using Blog.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blog.Api.Database
{
    public class UserDatabaseContext : DbContext
    {
        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options) : base(options)
        { }

        public DbSet<UserModel> UserModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception("optionsBuilder is not configured.");
            }
        }
    }
}
