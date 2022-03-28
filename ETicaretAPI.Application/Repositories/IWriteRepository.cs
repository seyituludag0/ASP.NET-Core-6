using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {

        Task<bool> AddAsync(T entity);
        Task<bool> ListAddRangeAsync(List<T> entity);
        bool Update(T entity);
        bool DeleteEntity(T entity);

        bool DeleteRange(List<T> entities);
        Task<bool> DeleteByIdAsync(int id);
        Task<int> SaveAsync();
    }
}
