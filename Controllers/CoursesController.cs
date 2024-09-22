using Microsoft.AspNetCore.Mvc;
using task3.Models;
using task7.Interfaces;

namespace task5.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
                return NotFound();

            return PartialView("_CourseDetails", course);
        }

        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            _courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            _courseService.UpdateCourse(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(Course model)
        {
            if (ModelState.IsValid)
            {
                _courseService.CreateCourse(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
