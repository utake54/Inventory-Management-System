using Inventory.Database.DataContextClass;
using Inventory.Database.IRepository;
using Inventory.Model.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database.Repository
{
    public class ProductRepository : IProductRepository
    {
        InventoryDBcontext db = new InventoryDBcontext();

        public async Task<List<Products>> ProductByCategories(int id)
        {
            var productlist = await db.ProductTable.Where(x => x.CategoryId == id).ToListAsync();
            return productlist;
        }

        public async Task AddProduct(Products product)
        {
            db.ProductTable.Add(product);
            await db.SaveChangesAsync();
        }

        public async Task<Products> ProductDetails(int id)
        {
            return await db.ProductTable.FirstOrDefaultAsync(x => x.ProductId == id);
        }
        public async Task EditProduct(Products product)
        {
            db.ProductTable.AddOrUpdate(product);
            await db.SaveChangesAsync();
        }
        public async Task DeleteProduct(Products product)
        {
            db.ProductTable.Remove(product);
            await db.SaveChangesAsync();
        }
    }
}
