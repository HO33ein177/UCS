using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCS.Domain.Entities;

public class Department
{
    public string Name { get; set; }
    
    [Key]
    public int DepartmentId { get; set; }
    
    public int DepartmentNumber { get; set; }
    
    
}