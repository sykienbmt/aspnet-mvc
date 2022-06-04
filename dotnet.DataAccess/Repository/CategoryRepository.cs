using dotnet.DataAccess.Repository.IRepository;
using dotnet.Models;

namespace dotnet.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db): base(db){
            _db=db;
        }

        public void Update(Category obj)
        {
            _db.Category.Update(obj);
        }
    }
}