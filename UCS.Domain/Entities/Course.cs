using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace UCS.Domain.Entities;

public class Course
{
    [Required]
    public string Name { get; set; }

    [Key]
    public int CourseId { get; set; }

    [Required]
    public string Level { get; set; }
    
    // [Required]
    // public Degree Degree { get; set; }

    [Required]
    public List<DateTime> Days { get; set; }

    [Required]
    public int DurationMinutes { get; set; }

    [ValidateNever]
    public Proffesor Teacher { get; set; }
    
    [ForeignKey("Proffesor")]
    [InverseProperty("Courses")]
    public int TeacherId { get; set; }
    
    [ValidateNever]
    public List<Student> Students { get; set; }
    
    [Required]
    public double CourseFee { get; set; }
    [ValidateNever]
    public Department Department { get; set; }
    
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    
    [Required]
    public int CourseCapacity { get; set; }
    
    [Required]
    public int Units { get; set; }
    
    [Required]
    public DateTime CourseExamDateTime { get; set; }
    
    [Required]
    public int ExamDurationMinutes { get; set; }
    
}