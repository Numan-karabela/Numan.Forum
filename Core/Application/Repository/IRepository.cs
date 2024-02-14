
using Domain.Entities.Common;
using System.Linq.Expressions;

namespace Application.Repository
{
    public interface IRepository<T>:IQuery<T> where T : class
    {
        Task<T> GettAllAsync(Expression<Func<T,bool>> filter=null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<bool> AddAsync(T Entity);
        Task<bool> UpdateAsync(T Entity);
        Task<bool> DeleteAsync(T Entity);
        Task<bool> DeleteIdAsync(int id);

    }
}
