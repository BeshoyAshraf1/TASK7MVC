using task3.Models;

namespace task7.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
        Course GetCourseById(int id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
    }
}
