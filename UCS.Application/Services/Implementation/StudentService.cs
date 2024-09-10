using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Application.Common.DTO;
using UCS.Application.Common.Interfaces;
using UCS.Application.Services.Interfaces;
using UCS.Domain.Entities;

namespace UCS.Application.Services.Implementation
{
    public class StudentService: IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Student GetStudentById(string id)
        {
            var student = _unitOfWork.Student.Get(u => u.Id == id, includeProperties: "Department");
            return student;
        }


        public async Task<BarNegativeChartDto> GetDebtsPurchasesBarChartData(long UMID)
        {
            //var student = _unitOfWork.Student.Get(u => u.UniqueMemberId == UMID);

            BarNegativeChartDto dto = new BarNegativeChartDto();
            //pieChartDto.Labels = ["New Customer", "returningCustomer"];
            //pieChartDto.Series = [newBookingsPercentage, returningPercentage];
            return dto;
        }
    }
}
