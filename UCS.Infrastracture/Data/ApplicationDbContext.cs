using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UCS.Domain.Entities;

namespace UCS.Infrastracture.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Student> Students { get; set; }

    public DbSet<Department> Departments { get; set; }

    public DbSet<Proffesor> Proffesors { get; set; }

    public DbSet<Course> Courses { get; set; }
}