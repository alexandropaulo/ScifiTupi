using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Article>()
            .HasOne(p => p.Category)
            .WithMany(b => b.Articles)
            .HasForeignKey(p => p.Catid);

            modelBuilder.Entity<Article>()
            .HasOne(p => p.User)
            .WithMany(b => b.Articles)
            .HasForeignKey(p => p.CreatedBy);
        }
    }
}