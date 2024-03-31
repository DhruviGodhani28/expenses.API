using expenses.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace expenses.API.Data
{

    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login> Logins { get; set; }
        
        public DbSet<Register> Registers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasKey(l => l.UserId);
            modelBuilder.Entity<Register>().HasKey(l => l.UserId);
        }
    }
}
