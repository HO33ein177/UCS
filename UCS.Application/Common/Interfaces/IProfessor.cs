using UCS.Domain.Entities;

namespace UCS.Application.Common.Interfaces;

public interface IProfessor: IRepository<Proffesor>
{
    void UpdateProfessor(Proffesor entity);

    void SaveChanges();
}