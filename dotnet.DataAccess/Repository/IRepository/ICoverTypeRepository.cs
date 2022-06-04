using dotnet.Models;

namespace dotnet.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository:IRepository<CoverType>
    {
        void Update (CoverType obj);
    }
}