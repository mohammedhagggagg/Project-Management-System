using Microsoft.EntityFrameworkCore;

namespace Project_Management_System.Contexts
{
    public class PMSDbContext:DbContext
    {
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Project> Projects  { get; set; }
        public DbSet<Models.Reports> Reports  { get; set; }
        public DbSet<Models.TaskItem> Tasks   { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=DESKTOP-6VNF5Q3;Database=PMSystem;Trusted_Connection=True;Encrypt=False");
        }

       


    }
}
