using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission_8_Assignment.Models
/// This code defines a TaskContext class that inherits from DbContext, which is part of the Entity Framework.
{
    public class TaskContext :DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { 
        }
        public DbSet<Task> Tasks { get; set; }

    }
}
