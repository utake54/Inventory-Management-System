using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database.IRepository
{
    public interface IProductRepository
    {
        Task<List<Products>> ProductByCategories(int id);
        Task AddProduct(Products product);

        Task<Products> ProductDetails(int id);

        Task EditProduct(Products product);
        Task DeleteProduct(Products product);
    }
}
