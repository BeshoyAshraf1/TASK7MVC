using task3.Models;
using Microsoft.EntityFrameworkCore;
using task7.Interfaces;

public class InstructorService : IInstructorService
{
    private readonly ApplicationDbContext _context;

    public InstructorService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Instractor> GetAllInstructors()
    {
        return _context.Instractors
            .Include(i => i.Courses)
            .Include(i => i.Depratments)
            .ToList();
    }

    public Instractor GetInstructorById(int id)
    {
        return _context.Instractors
            .Include(i => i.Courses)
            .Include(i => i.Depratments)
            .FirstOrDefault(x => x.Id == id);
    }

    public void CreateInstructor(Instractor instructor)
    {
        _context.Instractors.Add(instructor);
        _context.SaveChanges();
    }

    public void UpdateInstructor(Instractor instructor)
    {
        _context.Instractors.Update(instructor);
        _context.SaveChanges();
    }

    public void DeleteInstructor(int id)
    {
        var instructor = _context.Instractors.FirstOrDefault(x => x.Id == id);
        if (instructor != null)
        {
            _context.Instractors.Remove(instructor);
            _context.SaveChanges();
        }
    }
}
