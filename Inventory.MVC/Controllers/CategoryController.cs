using Inventory.Database.DataContextClass;
using Inventory.Model.Model;
using Inventory.Services.IService;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Inventory
        public async Task<ActionResult> CategoryList()
        {
            var data = await _categoryService.GetAllCategories();
            return View(data);
        }

        public ActionResult AddNewCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddNewCategory(Category category)
        {
            await _categoryService.AddCategory(category);
            return RedirectToAction("CategoryList");
        }

        public async Task<ActionResult> EditCategory(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<ActionResult> EditCategory(Category category)
        {
            await _categoryService.EditCategory(category);
            return RedirectToAction("CategoryList");
        }

        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCategory(int id, Category category)
        {
            await _categoryService.DeleteCategory(id, category);
            return RedirectToAction("CategoryList");
        }



    }
}