using BussinesLayer.Dtos;
using BussinesLayer.Interfaces;
using DataLayer.Repositories.Interfaces;
using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public sealed class AdministratorService : IAdministratorService
    {
        private readonly IUserRepository _repository;
        public AdministratorService(IUserRepository repository) 
        {
            _repository = repository;
        }
        public Task ExportLog()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Log>> GetLogs()
        {
            throw new NotImplementedException();
        }

        public async Task UserRegister(UserRequestDto user)
        {
            var users = await _repository.GetAll();

            if (users.Any(x => x.Email == user.Email))
            {
                throw new ObjectExistException("User");
            }

            await _repository.Add(new User
            {
                UserId = Guid.NewGuid(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Feeders = null
            });
        }
    }
}
