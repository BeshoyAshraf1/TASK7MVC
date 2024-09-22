using task3.Models;

namespace task7.Interfaces
{

    public interface IInstructorService
    {
        List<Instractor> GetAllInstructors();
        Instractor GetInstructorById(int id);
        void CreateInstructor(Instractor instructor);
        void UpdateInstructor(Instractor instructor);
        void DeleteInstructor(int id);
    }

}
