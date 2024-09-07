using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace UCS.Domain.Entities;

public class Student
{
    [Required]
    public string FullName { get; set; }
    [Key]
    public long StudentId { get; set; }
    
    [ValidateNever]
    public Department Department { get; set; }
    
    [Display(Name = "Faculty")]
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    
    [Required]
    [Display(Name = "State")]
    public StudentState State { get; set; }
    
    [Required]
    public Degree Degree { get; set; }
    
    [Required]
    public Major Major { get; set; }
    public List<Course>? Courses { get; set; }
   /* [ValidateNever]
    
   */
    
}