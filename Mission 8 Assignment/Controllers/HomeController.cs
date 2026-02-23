using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_8_Assignment.Models;

namespace Mission_8_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;
        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        // INDEX - Quadrant Page
        [HttpGet]
        public IActionResult Index()
        {
            var tasks = _repo.Tasks.Where(x => x.Completed == false).ToList();
            return View(tasks);
        }

        // GET: Add new task (show empty form)
        [HttpGet]
        public IActionResult AddTask()
        {
            return View(new Mission_8_Assignment.Models.Task());
        }

        // GET: Edit existing task (show form with data)
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            var task = _repo.Tasks.Single(x => x.TaskId == id);
            return View(task);
        }

        // POST: Save both new and edited tasks
        [HttpPost]
        public IActionResult SaveTask(Mission_8_Assignment.Models.Task t)
        {
            if (ModelState.IsValid)
            {
                if (t.TaskId == 0)  // New task (TaskId defaults to 0)
                {
                    _repo.AddTask(t);
                }
                else  // Existing task
                {
                    _repo.UpdateTask(t);  // You'll need this method
                }
                return RedirectToAction("Index");
            }
            return View(t);  // Return to same view if validation fails
        }

        // Delete
        public IActionResult Delete(int id)
        {
            var task = _repo.Tasks.Single(x => x.TaskId == id);
            _repo.DeleteTask(task);

            return RedirectToAction("Index");
        }


    }
}
