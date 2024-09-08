using UCS.Domain.Entities;

namespace UCS.Application.Common.Interfaces;

public interface IProfessor: IRepository<Professor>
{
    void UpdateProfessor(Professor entity);

    void SaveChanges();
}