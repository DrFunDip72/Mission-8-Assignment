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

        // GET: Add new task
        [HttpGet]
        public IActionResult ()
        {
            return View(new Mission_8_Assignment.Models.Task());
        }

        // Save new task
        [HttpPost]
        public IActionResult EditTask(Mission_8_Assignment.Models.Task t)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(t);
                return RedirectToAction("Index");
            }

            return View(t);
        }

        // GET: Edit existing task
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            var task = _repo.Tasks.Single(x => x.TaskId == id);

            return View(task);
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
