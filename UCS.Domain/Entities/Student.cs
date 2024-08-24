namespace UCS.Domain.Entities;

public class Student
{
    public string? FullName { get; set; }
    
    public long StudentId { get; set; }

    private string Degree { get; set; }

    private string Major { get; set; }
}