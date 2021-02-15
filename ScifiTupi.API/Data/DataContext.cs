using Microsoft.EntityFrameworkCore;

namespace ScifiTupi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Models.Article> Articles { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }
        public DbSet<Models.User> Users { get; set; }
    }
}