using DataLayer.Interfaces;
using DataLayer.Repositories.Interfaces;
using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly IFileManager _fileManager;
        private readonly IFileSystemPathProvider _fileSystemPathProvider;

        public UserRepository(IFileManager fileManager, IFileSystemPathProvider fileSystemPathProvider)
        {
            _fileManager = fileManager;
            _fileSystemPathProvider = fileSystemPathProvider;
        }

        public async Task<IReadOnlyCollection<User>> GetAll()
        {
            using var reader = File.OpenRead(_fileSystemPathProvider.GetUsersPath());
            return await JsonSerializer.DeserializeAsync<List<User>>(reader);
        }

        public Task<User> GetById(Guid id)
        {
            var users = GetAll().GetAwaiter().GetResult().ToList();

            var user = users.Find(x => x.UserId == id);
            return Task.FromResult(user);
        }

        public Task Add(User entity)
        {
            var users = GetAll().GetAwaiter().GetResult().ToList();

            if (users.Any(x => x.UserId == entity.UserId))
            {
                throw new ObjectExistException("User");
            }

            users.Add(entity);

            return Task.CompletedTask;
        }

        public Task Delete(User entity)
        {
            var users = GetAll().GetAwaiter().GetResult().ToList();

            if (users.Any(x => x.UserId == entity.UserId))
            {
                throw new ObjectExistException("User");
            }

            users.Remove(entity);

            return Task.CompletedTask;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

    }
}
