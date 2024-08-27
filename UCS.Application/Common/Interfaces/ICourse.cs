using UCS.Domain.Entities;

namespace UCS.Application.Common.Interfaces;

public interface ICourse: IRepository<Course>
{
    void UpdateCourse(Course entity);

    void SaveChanges();
    
}