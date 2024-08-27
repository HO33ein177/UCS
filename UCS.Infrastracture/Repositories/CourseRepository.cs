using System.Linq.Expressions;
using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class CourseRepository: Repository<Course>, ICourse
{
    private readonly ApplicationDbContext _db;

    public CourseRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void UpdateCourse(Course entity)
    {
        _db.Update(entity);
    }

    public void SaveChanges()
    {
        _db.SaveChanges();
    }
}