using Microsoft.AspNetCore.Mvc;
using task3.Models;
using task7.Interfaces;

namespace task5.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public IActionResult Index()
        {
            var instructors = _instructorService.GetAllInstructors();
            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            var instructor = _instructorService.GetInstructorById(id);
            if (instructor == null)
                return NotFound();

            return View(instructor);
        }

        [HttpPost]
        public IActionResult DeleteInstructor(int id)
        {
            _instructorService.DeleteInstructor(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateInstructor(Instractor model)
        {
            if (ModelState.IsValid)
            {
                _instructorService.CreateInstructor(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var instructor = _instructorService.GetInstructorById(id);
            if (instructor == null)
                return NotFound();

            return View(instructor);
        }

        [HttpPost]
        public IActionResult Edit(Instractor model)
        {
            _instructorService.UpdateInstructor(model);
            return RedirectToAction("Index");
        }
    }
}
