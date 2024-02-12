
namespace Application.Repository
{
    public interface IQuery<T> 
    {
        IQueryable<T> Query();
    }
}
