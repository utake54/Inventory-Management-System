using Inventory.Database.DataContextClass;
using Inventory.Model.Model;
using Inventory.Services.IService;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<ActionResult> ProductByCategory(int id)
        {
            var productlist = await _productService.GetProductsByCategory(id);
            TempData["id"] = id;
            return View(productlist);
        }

        public ActionResult AddProduct()
        {
            TempData.Keep("id");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                int categoryid = (int)TempData["id"];
                product.CategoryId = categoryid;
                await _productService.AddProduct(product);
                return RedirectToAction("ProductByCategory", new { id = categoryid });
            }

            return View();
        }


        public async Task<ActionResult> EditProduct(int id)
        {
            var data = await _productService.GetProductsById(id);
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> EditProduct(Products products)
        {
            int id = products.CategoryId;
            await _productService.EditProduct(products);
            return RedirectToAction("ProductByCategory", new { id });
        }

        public async Task<ActionResult> DeleteProduct(int id)
        {
            var data = await _productService.GetProductsById(id);
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteProduct(int id, Products product)
        {
            product = await _productService.GetProductsById(id);
            var categoryid = product.CategoryId;
            await _productService.DeleteProduct(product);
            return RedirectToAction("ProductByCategory", new { id = categoryid });
        }

        public async Task<ActionResult> ProductDetails(int id)
        {
            var data = await _productService.GetProductsById(id);
            return View(data);
        }


    }
}