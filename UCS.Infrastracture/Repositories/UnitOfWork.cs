using UCS.Application.Common.Interfaces;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public readonly ApplicationDbContext _db;

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Student = new StudentRepository(_db);
        Department = new DepartmentRepository(_db);
        Course = new CourseRepository(_db);
        Professor = new ProfessorRepository(_db);
    }
    
    public IStudent Student { get; private set; }
    public IDepartment Department { get; private set; }
    public ICourse Course { get; private set; }
    public IProfessor Professor { get; private set; }
}