using Asp.Net_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Movie_DataAccess.Data;
using Movie_DataAccess.Repository.IRepository;

namespace Asp.Net_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository db)
        {
            _categoryRepository = db;
        }
        [Route("Categories")]
        public IActionResult Index()
        {
            List<Category> objCategoryList= _categoryRepository.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name");
            }
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(obj);
                _categoryRepository.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _categoryRepository.Get(input=>input.CategoryId == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(input=>input.CategoryId==id);
            //Category? categoryFromDb2 = _db.Categories.Where(input=>input.CategoryId==id).FirstOrDefault();
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if(ModelState.IsValid)
            {
                _categoryRepository.Update(obj);
                _categoryRepository.Save();
                TempData["success"] = "Category updated successfully";

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _categoryRepository.Get(input => input.CategoryId == id);

            if (categoryFromDb == null)
            {
                return NotFound(); 
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? obj = _categoryRepository.Get(input => input.CategoryId == id);
            if (obj == null)
            {
                return NotFound();
            }
            _categoryRepository.Remove(obj);
            _categoryRepository.Save();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
