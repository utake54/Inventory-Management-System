using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services.IService
{
    public interface IProductService
    {
        Task<List<Products>> GetProductsByCategory(int id);

        Task AddProduct(Products product);

        Task<Products> GetProductsById(int id);
        Task EditProduct(Products product);
        Task DeleteProduct(Products product);
    }
}
