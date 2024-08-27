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
    [Required]
    public string Degree { get; set; }

    // [Required]
    public string Major { get; set; }
    
    [ValidateNever]
    public Department Department { get; set; }
    
    [Display(Name = "Faculty")]
    [ForeignKey("Department")]
    public int FacultyId { get; set; }
}