using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using UCS.Application.Common.Interfaces;
using UCS.Infrastracture.Data;

namespace UCS.Infrastracture.Repositories;

public class Repository<T> : IRepository<T> where T: class
{
    private readonly ApplicationDbContext _db;
    internal DbSet<T> DbSet;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        DbSet = db.Set<T>();
    }
    
    
    public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<T> query = DbSet;
        if (filter is not null)
        {
            query = query.Where(filter);
        }

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                         .Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }

        return query.ToList();
        
    }

    public T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null)
    {
        IQueryable<T> query = DbSet;
        if (filter is not null)
        {
            query = query.Where(filter);
        }

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                         .Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }

        return query.FirstOrDefault();
    }

    public void Add(T entity)
    {
        DbSet.Add(entity);
    }

    public void Remove(T entity)
    {
        DbSet.Remove(entity);
    }

    
}