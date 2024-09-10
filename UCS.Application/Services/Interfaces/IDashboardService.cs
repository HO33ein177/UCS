using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Application.Common.DTO;

namespace UCS.Application.Services.Interfaces
{
    public interface IDashboardService
    {
        public IStudentService StudentService { get; }
        public IProfessorService ProfessorService { get; }
        public IAdminService AdminService { get; }

    }
}
