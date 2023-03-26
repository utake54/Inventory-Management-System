using Inventory.Database.IRepository;
using Inventory.Database.Repository;
using Inventory.Services.IService;
using Inventory.Services.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Inventory.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();



            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<ICategoryRepository, Categoryrepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductService, ProductService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}