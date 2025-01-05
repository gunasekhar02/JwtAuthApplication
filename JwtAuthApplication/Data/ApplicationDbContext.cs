using JwtAuthApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
