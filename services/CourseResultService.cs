using task3.Models;
using Microsoft.EntityFrameworkCore;
using task7.Interfaces;

public class CourseResultService : ICourseResultService
{
    private readonly ApplicationDbContext _context;

    public CourseResultService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Courseresult> GetAllCourseResults()
    {
        return _context.Courseresults
            .Include(i => i.Courses)
            .Include(i => i.trainees)
            .ToList();
    }

    public Courseresult GetCourseResultById(int id)
    {
        return _context.Courseresults
            .Include(i => i.Courses)
            .Include(i => i.trainees)
            .FirstOrDefault(x => x.Id == id);
    }

    public void CreateCourseResult(Courseresult courseResult)
    {
        _context.Courseresults.Add(courseResult);
        _context.SaveChanges();
    }

    public void UpdateCourseResult(Courseresult courseResult)
    {
        _context.Courseresults.Update(courseResult);
        _context.SaveChanges();
    }

    public void DeleteCourseResult(int id)
    {
        var courseResult = _context.Courseresults.FirstOrDefault(x => x.Id == id);
        if (courseResult != null)
        {
            _context.Courseresults.Remove(courseResult);
            _context.SaveChanges();
        }
    }
}
