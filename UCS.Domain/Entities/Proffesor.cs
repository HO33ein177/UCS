using System.ComponentModel.DataAnnotations;

namespace UCS.Domain.Entities;

public class Proffesor
{
    public string FullName { get; set; }

    [Key]  
    public int ProfId { get; set; }
    
    public Department Department { get; set; }
    
    
    public ProfessorState State { get; set; }

    public ICollection<Course> Courses { get; set; }
    
    
}