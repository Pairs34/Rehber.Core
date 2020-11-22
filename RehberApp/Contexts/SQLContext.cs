using Microsoft.EntityFrameworkCore;
using RehberApp.Entities;

namespace RehberApp.Contexts
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=awssqlserver.cdib5b6yqxru.us-east-1.rds.amazonaws.com;database=RehberDB;user=admin;password=Yldrm!34");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rehber>().HasIndex(x => x.id).IsUnique();
        }

        public DbSet<Rehber> rehbers { get; set; }
    }
}