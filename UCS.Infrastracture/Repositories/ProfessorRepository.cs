using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class ProfessorRepository: Repository<Professor>, IProfessor
{
    private readonly ApplicationDbContext _db;
    public ProfessorRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void UpdateProfessor(Professor entity)
    {
        _db.Update(entity);
    }

    public void SaveChanges()
    {
        _db.SaveChanges();
    }
}