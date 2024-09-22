using task3.Models;
namespace task7.Interfaces
{


    public interface IDepartmentService
    {
        List<Depratment> GetAllDepartments();
        Depratment GetDepartmentById(int id);
        void CreateDepartment(Depratment department);
        void UpdateDepartment(Depratment department);
        void DeleteDepartment(int id);
    }

}
