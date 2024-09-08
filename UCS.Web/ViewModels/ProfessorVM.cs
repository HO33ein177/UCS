using Microsoft.AspNetCore.Mvc.Rendering;
using UCS.Domain.Entities;

namespace UniCourseSelect.ViewModels;

public class ProfessorVM
{
    public Professor Professor { get; set; }
    
    public IEnumerable<SelectListItem> DepartmentList { get; set; }
    
    public IEnumerable<SelectListItem> StateList { get; set; }
}