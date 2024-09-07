using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCS.Domain.Entities;

public class Proffesor
{
    public string FullName { get; set; }

    [Key]  
    public int ProfId { get; set; }


    [ValidateNever]
    public Department Department { get; set; }

    [ForeignKey(nameof(Department))]
    public int DepartmentId { get; set; }


    public ProfessorState State { get; set; }

    public ICollection<Course> Courses { get; set; }
    
    
}