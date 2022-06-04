using dotnet.DataAccess.Repository.IRepository;
using dotnet.Models;

namespace dotnet.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db): base(db){
            _db=db;
        }

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}