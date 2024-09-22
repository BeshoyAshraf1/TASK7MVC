using task3.Models;
using Microsoft.EntityFrameworkCore;
using task7.Interfaces;

public class DepartmentService : IDepartmentService
{
    private readonly ApplicationDbContext _context;

    public DepartmentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Depratment> GetAllDepartments()
    {
        return _context.Depratments
            .Include(i => i.Instractors)
            .ToList();
    }

    public Depratment GetDepartmentById(int id)
    {
        return _context.Depratments
            .Include(i => i.Instractors)
            .FirstOrDefault(x => x.id == id);
    }

    public void CreateDepartment(Depratment department)
    {
        _context.Depratments.Add(department);
        _context.SaveChanges();
    }

    public void UpdateDepartment(Depratment department)
    {
        _context.Depratments.Update(department);
        _context.SaveChanges();
    }

    public void DeleteDepartment(int id)
    {
        var department = _context.Depratments.FirstOrDefault(x => x.id == id);
        if (department != null)
        {
            _context.Depratments.Remove(department);
            _context.SaveChanges();
        }
    }
}
