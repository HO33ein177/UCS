using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace UCS.Domain.Entities;

public class Student : ApplicationUser
{
    public ICollection<Course>? Courses { get; set; }
    public bool Allowed { get; set; } = true;//todo


    //[Required]
    [Display(Name = "State")]
    public StudentState State { get; set; }
    
    [Required]
    public Degree Degree { get; set; }
    
    [Required]
    public Major Major { get; set; }
   /* [ValidateNever]
    
   */
    
}