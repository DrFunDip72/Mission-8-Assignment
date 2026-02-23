namespace Mission_8_Assignment.Models
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
    }
}
