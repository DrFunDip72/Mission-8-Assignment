using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission_8_Assignment.Models
{
    public class TaskContext :DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { 
        }
        public DbSet<Task> Tasks { get; set; }

    }
}
