using dotnet.Models;

namespace dotnet.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update (Category obj);
    }
}