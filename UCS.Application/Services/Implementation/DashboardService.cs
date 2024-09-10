using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Application.Common.Interfaces;
using UCS.Application.Services.Interfaces;

namespace UCS.Application.Services.Implementation
{
    public class DashboardService : IDashboardService
    {
        public IStudentService StudentService { get; private set; }
        public IProfessorService ProfessorService { get; private set; }

        public IAdminService AdminService { get; private set; }

        public DashboardService(IStudentService studentService, IProfessorService professorService, IAdminService adminService)
        {
            StudentService = studentService;
            ProfessorService = professorService;
            AdminService = adminService;
        }
    }
}
