using dotnet.DataAccess;
using dotnet.DataAccess.Repository.IRepository;
using dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.shop.Controllers
{[Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<CoverType> objCoverTypeList = _unitOfWork.CoverType.GetAll();
            return View(objCoverTypeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType obj)
        {
            _unitOfWork.CoverType.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "CoverType created successfully";
            return RedirectToAction("Index");

        }

        //GET
        public IActionResult Edit(int? id)
        {
            Console.WriteLine(id);
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // var categoryFromDb = _db.Category.Find(id);
            var coverTypeFromDbFirst = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (coverTypeFromDbFirst == null)
            {
                return NotFound();
            }

            return View(coverTypeFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType obj)
        {

            _unitOfWork.CoverType.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "CoverType updated successfully";
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var coverTypeFromDb = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (coverTypeFromDb == null)
            {
                return NotFound();
            }

            return View(coverTypeFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.CoverType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "CoverType deleted successfully";
            return RedirectToAction("Index");

        }
    }
}