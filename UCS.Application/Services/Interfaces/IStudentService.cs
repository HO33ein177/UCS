using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Application.Common.DTO;
using UCS.Application.Common.Interfaces;
using UCS.Domain.Entities;

namespace UCS.Application.Services.Interfaces
{
    public interface IStudentService
    {
        Task<BarNegativeChartDto> GetDebtsPurchasesBarChartData(long UMID);
        Student GetStudentById(string id);

    }
}
