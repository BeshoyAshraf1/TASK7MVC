using Microsoft.AspNetCore.Mvc;
using task3.Models;
using task7.Interfaces;

namespace task5.Controllers
{
    public class CourseResultController : Controller
    {
        private readonly ICourseResultService _courseResultService;

        public CourseResultController(ICourseResultService courseResultService)
        {
            _courseResultService = courseResultService;
        }

        public IActionResult Index()
        {
            var courseResults = _courseResultService.GetAllCourseResults();
            return View(courseResults);
        }

        public IActionResult Details(int id)
        {
            var courseResult = _courseResultService.GetCourseResultById(id);
            if (courseResult == null)
                return NotFound();

            return View(courseResult);
        }

        [HttpPost]
        public IActionResult DeleteCourseResult(int id)
        {
            _courseResultService.DeleteCourseResult(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourseResult(Courseresult model)
        {
            if (ModelState.IsValid)
            {
                _courseResultService.CreateCourseResult(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var courseResult = _courseResultService.GetCourseResultById(id);
            if (courseResult == null)
                return NotFound();

            return View(courseResult);
        }

        [HttpPost]
        public IActionResult Edit(Courseresult model)
        {
            _courseResultService.UpdateCourseResult(model);
            return RedirectToAction("Index");
        }
    }
}
