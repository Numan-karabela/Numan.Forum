
using Domain.Entities.Common;

namespace Application.Repository
{
    public interface IQuery<T> where T : BaseEntity
    {
        IQueryable<T> Query();
    }
}
