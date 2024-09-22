
using task3.Models;

namespace task7.Interfaces
{

    public interface ICourseResultService
    {
        List<Courseresult> GetAllCourseResults();
        Courseresult GetCourseResultById(int id);
        void CreateCourseResult(Courseresult courseResult);
        void UpdateCourseResult(Courseresult courseResult);
        void DeleteCourseResult(int id);
    }

}
