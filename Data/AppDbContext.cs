using Microsoft.EntityFrameworkCore;
using SharedCalendar.Models;

namespace SharedCalendar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Message> Messages => Set<Message>();
    }
}
