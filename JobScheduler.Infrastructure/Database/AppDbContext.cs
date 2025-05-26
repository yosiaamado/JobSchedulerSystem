using Microsoft.EntityFrameworkCore;
using JobScheduler.Domain.Entities;

namespace JobScheduler.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Job> Jobs => Set<Job>();
        public DbSet<JobTemplate> JobTemplates => Set<JobTemplate>();
        public DbSet<JobMapping> JobMappings => Set<JobMapping>();
        public DbSet<JobExecutionLog> JobExecutionLogs => Set<JobExecutionLog>();
        public DbSet<DatabaseConnection> DatabaseConnections => Set<DatabaseConnection>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasKey(e => e.Id);
            modelBuilder.Entity<JobTemplate>().HasKey(e => e.Id);
            modelBuilder.Entity<JobMapping>().HasKey(e => e.Id);
            modelBuilder.Entity<JobExecutionLog>().HasKey(e => e.Id);
            modelBuilder.Entity<DatabaseConnection>().HasKey(e => e.Id);
        }
    }
}
