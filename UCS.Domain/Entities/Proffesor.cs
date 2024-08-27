using System.ComponentModel.DataAnnotations;

namespace UCS.Domain.Entities;

public class Proffesor
{
    public string FullName { get; set; }

    [Key]  
    public int ProfId { get; set; }

    public string State { get; set; }

    public string Degree { get; set; }

    public Department Department { get; set; }
    
}