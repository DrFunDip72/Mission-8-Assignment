namespace Mission_8_Assignment.Models
/// This code defines an interface ITaskRepository that declares methods for managing a collection of Task objects.
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        void AddTask(Task task);
        void UpdateTask(Task task); 
        void DeleteTask(Task task); 
    }
}
