using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database.IRepository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> AllCategories();
        Task AddNewCategory(Category category);

        Task DeleteCategory(int id, Category category);

        Task EditCategory(Category category);
        Task<Category> DetailsofCategory(int id);

    }
}
