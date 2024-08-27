using UCS.Domain.Entities;

namespace UCS.Application.Common.Interfaces;

public interface IDepartment: IRepository<Department>
{
    void UpdateDepartment(Department entity);

    void SaveChanges();
}