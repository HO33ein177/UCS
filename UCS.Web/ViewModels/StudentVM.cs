using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Domain.Entities;

namespace UniCourseSelect.ViewModels;

public class StudentVM
{
    public Student? Student { get; set; }
    
    [ValidateNever]
    public IEnumerable<SelectListItem>? DepartmentList { get; set; }
}