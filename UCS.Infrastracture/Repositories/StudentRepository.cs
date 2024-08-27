using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class StudentRepository : Repository<Student>, IStudent
{
    private ApplicationDbContext _db;

    public StudentRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }
    
    public void UpdateStudent(Student entity)
    {
        _db.Update(entity);
    }

    public void SaveChanges()
    {
        _db.SaveChanges();
    }
}