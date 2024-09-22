using Microsoft.AspNetCore.Mvc;
using task3.Models;
using task7.Interfaces;

namespace task5.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }

        public IActionResult Details(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        [HttpPost]
        public IActionResult DeleteDepartment(int id)
        {
            _departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(Depratment model)
        {
            if (ModelState.IsValid)
            {
                _departmentService.CreateDepartment(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Depratment model)
        {
            _departmentService.UpdateDepartment(model);
            return RedirectToAction("Index");
        }
    }
}
