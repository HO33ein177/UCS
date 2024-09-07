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
        
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>().HasData(
            new Department
            {
                Name = "CE", DepartmentId = 1,
                DepartmentNumber = 11
            },
            new Department
            {
                Name = "CSMath",
                DepartmentId = 5,
                DepartmentNumber = 10
            },
            new Department
            {
                Name = "EE",
                DepartmentId = 2,
                DepartmentNumber = 12
            },
            new Department
            {
                Name = "Physics",
                DepartmentId = 3,
                DepartmentNumber = 13
            },
            new Department
            {
                Name = "Languages",
                DepartmentId = 4,
                DepartmentNumber = 14
            }
);
        modelBuilder.Entity<Proffesor>().HasData(
            new Proffesor
            {
                FullName = "firstmath lastname",
                ProfId = 6,
                DepartmentId = 5,
            },
            new Proffesor
            {
                FullName = "scndmath lastname",
                ProfId = 1,
                DepartmentId = 5,
            },
            new Proffesor
            {
                FullName = "firstce lastname",
                ProfId = 2,
                DepartmentId = 1,
            },
            new Proffesor
            {
                FullName = "firstee lastname",
                ProfId = 3,
                DepartmentId = 2,
            },
            new Proffesor
            {
                FullName = "firstphys lastname",
                ProfId = 4,
                DepartmentId = 3,
            },
            new Proffesor
            {
                FullName = "firstlang lastname",
                ProfId = 5,
                DepartmentId = 4,
            }

);
        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Name = "Calculus 1",
                DepartmentId = 5,
                CourseCapacity = 100,
                CourseFee = 50.0,
                CourseId = 1,
                Level = Degree.Bachelor,
                TeacherId = 6,
                Units = 4,
                Days = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Tuesday},
                StartHour = new TimeOnly(10, 30),
                DurationMinutes = 120,
                
            },
             new Course
             {
                 Name = "Calculus 2",
                 DepartmentId = 5,
                 CourseCapacity = 100,
                 CourseFee = 50.0,
                 CourseId = 2,
                 Level = Degree.Bachelor,
                 TeacherId = 1,
                 Units = 4,
                 Days = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Monday },
                 StartHour = new TimeOnly(10, 30),
                 DurationMinutes = 120,
             },
             new Course
             {
                 Name = "Holiday Physics 1",
                 DepartmentId = 3,
                 CourseCapacity = 100,
                 CourseFee = 50.0,
                 CourseId = 3,
                 Level = Degree.Bachelor,
                 TeacherId = 2,
                 Units = 3,
                 Days = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Tuesday },
                 StartHour = new TimeOnly(8, 30),
                 DurationMinutes = 120,
             },
             new Course
             {
                 Name = "Holiday Physics 2",
                 DepartmentId = 3,
                 CourseCapacity = 100,
                 CourseFee = 50.0,
                 CourseId = 4,
                 Level = Degree.Bachelor,
                 TeacherId = 3,
                 Units = 3,
                 Days = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Monday },
                 StartHour = new TimeOnly(8, 30),
                 DurationMinutes = 120,
             }

            );
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                FullName= "Hosein BN",
                DepartmentId= 1,
                State = StudentState.MustPayTuition,
                StudentId= 990342348,
                Degree = Degree.Bachelor,
                Major = Major.ComputerAndInformationSciences,
                
            }
            );

         }
}