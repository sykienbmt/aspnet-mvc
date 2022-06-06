using dotnet.Models;

namespace dotnet.DataAccess.Repository.IRepository
{
    public interface IProductRepository:IRepository<Product>
    {
        void Update (Product obj);
    }
}