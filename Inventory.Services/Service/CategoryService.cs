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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(Category category)
        {
            await _categoryRepository.AddNewCategory(category);
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _categoryRepository.AllCategories();
        }

        public async Task DeleteCategory(int id, Category category)
        {
            await _categoryRepository.DeleteCategory(id, category);
        }
        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.DetailsofCategory(id);

        }

        public async Task EditCategory(Category category)
        {
            await _categoryRepository.EditCategory(category);
        }
    }
}
