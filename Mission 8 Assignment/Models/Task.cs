using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.WebRequestMethods;
// This code defines a Task class with properties for TaskId, TaskName, DueDate, Quadrant, Category, and Completed.
namespace Mission_8_Assignment.Models
{
    public class Task
    {
        [Key]
        [Required]
 
        public int TaskId { get; set; } 
       
        [Required]
        public string TaskName { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        public string Quadrant { get; set; }

        public string Category { get; set; }

        public bool Completed { get; set; }
    }
}
