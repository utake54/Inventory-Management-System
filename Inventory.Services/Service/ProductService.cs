using Inventory.Database.IRepository;
using Inventory.Model.Model;
using Inventory.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productrepository;
        public ProductService(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }

        public async Task<List<Products>> GetProductsByCategory(int id)
        {
            return await _productrepository.ProductByCategories(id);

        }

        public async Task AddProduct(Products product)
        {
            await _productrepository.AddProduct(product);
        }
        public async Task<Products> GetProductsById(int id)
        {
            return await _productrepository.ProductDetails(id);
        }

        public async Task EditProduct(Products product)
        {
            await _productrepository.EditProduct(product);
        }
        public async Task DeleteProduct(Products product)
        {
            await _productrepository.DeleteProduct(product);
        }
    }
}
