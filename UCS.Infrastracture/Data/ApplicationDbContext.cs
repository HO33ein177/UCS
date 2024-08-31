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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Course>()
                 .HasOne(c => c.Teacher)
                 .WithMany(t => t.Courses)
                 .HasForeignKey(c => c.TeacherId)
                 .OnDelete(DeleteBehavior.Restrict); // This prevents cascade delete/update
         }
}