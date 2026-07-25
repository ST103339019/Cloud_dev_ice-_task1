using Microsoft.AspNetCore.Mvc;
using UniversityCourses.Models;
using UniversityCourses.Services;

namespace UniversityCourses.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AzureTableService azureTableService;

        public CoursesController(AzureTableService service)
        {
            azureTableService = service;
        }
         
        //  this will show  all courses
        public async Task<IActionResult> Index()
        {
            List<Course> courses = await azureTableService.GetCourses();

            return View(courses);
        }

        // this showss the page for adding a course
        public IActionResult Create()
        {
            return View();
        }

        // Saves a new course
        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                await azureTableService.AddCourse(course);

                return RedirectToAction("Index");
            }

            return View(course);
        }

        // Shows one course
        public async Task<IActionResult> Details(string id)
        {
            Course? course = await azureTableService.GetCourse(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // Shows the edit page
        public async Task<IActionResult> Edit(string id)
        {
            Course? course = await azureTableService.GetCourse(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // Saves the edited course
        [HttpPost]
        public async Task<IActionResult> Edit(string id, Course course)
        {
            if (id != course.RowKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await azureTableService.UpdateCourse(course);

                return RedirectToAction("Index");
            }

            return View(course);
        }

        // Shows the delete confirmation page
        public async Task<IActionResult> Delete(string id)
        {
            Course? course = await azureTableService.GetCourse(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // Deletes the course
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await azureTableService.DeleteCourse(id);

            return RedirectToAction("Index");
        }
    }
}

// References
// Microsoft 2026, ASP.NET Core MVC controllers, Microsoft Learn [Online].
// Available at: https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/actions.
// Accessed on 25 July 2026.