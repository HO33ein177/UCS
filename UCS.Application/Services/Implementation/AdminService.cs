using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Application.Common.DTO;
using UCS.Application.Common.Interfaces;
using UCS.Application.Services.Interfaces;

namespace UCS.Application.Services.Implementation
{
    public class AdminService: IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdminService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



    }
}
