using Entities;
using Entities.Feeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Interfaces
{
    public interface IUser
    {
        Task AddFeeder(Feeder feeder);
        Task AddMark(string mark);
        Task CreateTimetable();
        Task UpdateTimetable(string name); 
        Task DeleteTimetable(string name);
        Task Monitoring();
        Task<IReadOnlyCollection<Log>> GetLogs();
        Task ManualControl();
    }
}
