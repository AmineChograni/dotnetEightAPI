using dotnetEightAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetEightAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
