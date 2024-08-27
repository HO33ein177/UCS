using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class DepartmentRepository: Repository<Department>, IDepartment
{
    private readonly ApplicationDbContext _db;
    private IDepartment _departmentImplementation;

    public DepartmentRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }


    public void UpdateDepartment(Department entity)
    {
        _db.Update(entity);
    }

    public void SaveChanges()
    {
        _db.SaveChanges();
    }
}