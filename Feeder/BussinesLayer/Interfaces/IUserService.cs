using BussinesLayer.Dtos;
using Entities;
using Entities.Feeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Interfaces
{
    public interface IUserService
    {
        Task AddFeeder(Guid userId, FeederRequestDto feeder);
        Task AddMark(string mark);
        Task CreateTimetable();
        Task<TimetableDto> GetTimetable(string nameOfTimetable);
        Task UpdateTimetable(string nameOfTimetable); 
        Task DeleteTimetable(string nameOfTimetable);
        Task Monitoring();
        Task<IReadOnlyCollection<Log>> GetLogs();
        Task ManualControl();
    }
}
