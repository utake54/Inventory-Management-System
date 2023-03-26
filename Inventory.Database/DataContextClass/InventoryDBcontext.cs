using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database.DataContextClass
{
    public class InventoryDBcontext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> ProductTable { get; set; }


    }
}
