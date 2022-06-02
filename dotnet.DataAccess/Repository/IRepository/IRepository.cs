using System.Linq.Expressions;
namespace dotnet.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {

        T GetFirstOrDefault(Expression<Func<T,bool>> filter);
        IEnumerable<T> GetAll();

        void Add(T entity);
    }
}