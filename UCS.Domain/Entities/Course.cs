using System.ComponentModel.DataAnnotations;

namespace UCS.Domain.Entities;

public class Course
{
    public string Name { get; set; }

    [Key]
    public int CourseId { get; set; }

    public string Level { get; set; }

    public List<DateTime> Days { get; set; }

    public int DuratoionMinutes { get; set; }


}