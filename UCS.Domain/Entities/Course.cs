using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace UCS.Domain.Entities;

public class Course
{
    [Required]
    public string Name { get; set; }

    [Key]
    public long CourseId { get; set; }

    [Required]
    public Degree Level { get; set; }

    // [Required]
    // public Degree Degree { get; set; }

    public List<DayOfWeek> Days { get; set; }

    public TimeOnly StartHour { get; set; }

    [Required]
    public int DurationMinutes { get; set; }
    
   // [ValidateNever]
    //public Professor Teacher { get; set; }
    
    //[ForeignKey("Professor")]
    //[InverseProperty("Courses")]
    //public int TeacherId { get; set; }
   
   //[ValidateNever]
    
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