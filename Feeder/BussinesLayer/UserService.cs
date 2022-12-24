using BussinesLayer.Dtos;
using BussinesLayer.Enums;
using BussinesLayer.Interfaces;
using DataLayer.Repositories.Interfaces;
using Entities;
using Entities.Feeders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public sealed class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) 
        {
            _repository = repository;
        }
        public async Task AddFeeder(Guid userId,FeederRequestDto feeder)
        {
            var user = await _repository.GetById(userId);
            if (user is null)
            {
                throw new NullReferenceException(nameof(user));
            }

            Feeder newFeeder;
            if (feeder.Type == FeederType.WithDispenser)
            {
                newFeeder = new FeederWithDispenser
                {
                    Model = feeder.Model,
                    Capacity = feeder.Capacity,
                    Size = feeder.Size,
                    State = "null",
                    Timetable = null,
                    CapacityPerOne = 20
                };
            }
            else
            {
                newFeeder = new FeederWithWeightSensor
                {
                    Model = feeder.Model,
                    Capacity = feeder.Capacity,
                    Size = feeder.Size,
                    State = "null",
                    Timetable = null,
                    Weight = 20
                };
            }

            if (user.Feeders is null)
            {
                user.Feeders = new List<Feeder> 
                {
                    newFeeder
                };
            }
            else
            {
                user.Feeders.Add(newFeeder);
            }

            _repository.Update(user);
        }

        public Task AddMark(string mark)
        {
            throw new NotImplementedException();
        }

        public Task CreateTimetable()
        {
            throw new NotImplementedException();
        }

        public Task DeleteTimetable(string nameOfTimetable)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Log>> GetLogs()
        {
            throw new NotImplementedException();
        }

        public Task<TimetableDto> GetTimetable(string nameOfTimetable)
        {
            throw new NotImplementedException();
        }

        public Task ManualControl()
        {
            throw new NotImplementedException();
        }

        public Task Monitoring()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTimetable(string nameOfTimetable)
        {
            throw new NotImplementedException();
        }
    }
}
