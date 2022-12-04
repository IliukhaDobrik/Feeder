using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<IReadOnlyCollection<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Add(TEntity entity);
        void Update(TEntity entity);
        Task Delete(TEntity entity);
        Task Save();
    }
}
