using task3.Models;
using Microsoft.EntityFrameworkCore;
using task7.Interfaces;


namespace task7.services
{

    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses
                .Include(i => i.Instractors)
                .Include(i => i.Courseresults)
                .ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses
                .Include(i => i.Instractors)
                .Include(i => i.Courseresults)
                .FirstOrDefault(x => x.Id == id);
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }

}
