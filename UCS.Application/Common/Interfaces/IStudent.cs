using System.Linq.Expressions;
using UCS.Domain.Entities;

namespace UCS.Application.Common.Interfaces;

public interface IStudent: IRepository<Student>
{
    void UpdateStudent(Student entity);


    void SaveChanges();
    bool Any(Func<Student, bool> filter);
}