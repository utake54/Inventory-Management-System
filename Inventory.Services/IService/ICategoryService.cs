using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services.IService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();

        Task AddCategory(Category category);

        Task DeleteCategory(int id, Category category);

        Task<Category> GetCategoryById(int id);

        Task EditCategory(Category category);
    }
}
