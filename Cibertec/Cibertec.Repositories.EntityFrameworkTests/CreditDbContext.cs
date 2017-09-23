using Cibertec.Models;
using Microsoft.EntityFrameworkCore;

namespace Cibertec.Repositories.EntityFrameworkTests
{
    public class CreditDbContext: DbContext
    {
        public DbSet<Corporation> Corporations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>().ToTable("corporation");
            modelBuilder.Entity<Member>().ToTable("member");
        }
    }
}
