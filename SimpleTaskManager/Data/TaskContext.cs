using Microsoft.EntityFrameworkCore;
using SimpleTaskManager.Models;

namespace SimpleTaskManager.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<UserTask> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().ToTable("UserTask");

        }
    }
}