using DotNetCorePrac.Data;
using DotNetCorePrac.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCorePrac.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext) {  _dbContext = dbContext; }

        public IActionResult Index()
        {
            List<Category> categories = _dbContext.Categories.ToList<Category>();
            return View(categories);
        }
            
        public IActionResult Create() {

            return View("AddNewCategory");
        }
        [HttpPost]
        public IActionResult AddNewCategory(Category newCategory) {

            // add custom error message from controller
            if (newCategory.DisplayOrder == 50)
            {
                ModelState.AddModelError("DisplayOrder", "Display Order cannot be 50");
            }


            if (newCategory != null && ModelState.IsValid)
            {
                _dbContext.Categories.Add(newCategory);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(); 
        }


    }
}
