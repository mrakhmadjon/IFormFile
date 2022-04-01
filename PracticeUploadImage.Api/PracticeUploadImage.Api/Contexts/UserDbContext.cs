using Microsoft.EntityFrameworkCore;
using PracticeUploadImage.Api.Models;

namespace PracticeUploadImage.Api.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
