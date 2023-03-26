using Inventory.Database.DataContextClass;
using Inventory.Database.IRepository;
using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database.Repository
{

    public class Categoryrepository : ICategoryRepository
    {
        InventoryDBcontext db = new InventoryDBcontext();

        public async Task AddNewCategory(Category category)
        {
            db.Categories.Add(category);
            await db.SaveChangesAsync();
        }

        public async Task<List<Category>> AllCategories()
        {
            List<Category> categorylist = await db.Categories.ToListAsync();
            return categorylist;
        }

        public async Task DeleteCategory(int id, Category category)
        {
            category = await db.Categories.FirstOrDefaultAsync(z => z.CategoryId == id);
            db.Categories.Remove(category);
            await db.SaveChangesAsync();

        }

        public async Task<Category> DetailsofCategory(int id)
        {
            var data = await db.Categories.FirstOrDefaultAsync(z => z.CategoryId == id);
            return data;
        }

        public async Task EditCategory(Category category)
        {
            db.Categories.AddOrUpdate(category);
            await db.SaveChangesAsync();
        }
    }
}
