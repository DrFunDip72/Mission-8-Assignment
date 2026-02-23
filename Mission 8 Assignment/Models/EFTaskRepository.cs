namespace Mission_8_Assignment.Models
/// This code defines a class EFTaskRepository that implements the ITaskRepository interface. 
/// It uses Entity Framework to interact with a database context (TaskContext) to manage a collection of Task objects. 
/// The Tasks property retrieves all tasks from the database, and the other methods (AddTask, UpdateTask, DeleteTask) 
/// perform the corresponding operations on the database and save changes.
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskContext _context;

        public EFTaskRepository(TaskContext temp)
        {
            _context = temp;
        }

        public List<Task> Tasks => _context.Tasks.ToList();

        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
