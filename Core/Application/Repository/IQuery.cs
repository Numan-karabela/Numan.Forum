
using Domain.Entities.Common;
using System.Data.Entity;

namespace Application.Repository
{
    public interface IQuery<T> where T : BaseEntity
    {
        IQueryable<T> Query();
    }
}
