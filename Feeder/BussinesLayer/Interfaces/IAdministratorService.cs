using BussinesLayer.Dtos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Interfaces
{
    public interface IAdministratorService
    {
        Task UserRegister(UserRequestDto user);
        Task<IReadOnlyCollection<Log>> GetLogs();
        Task ExportLog();
    }
}
