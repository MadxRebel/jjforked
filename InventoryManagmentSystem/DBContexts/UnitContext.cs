using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem
{
    public class BrandContext: DbContext
    {
        DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder _dbContextOptionsBuilder)
        {
            _dbContextOptionsBuilder.UseSqlite("data source=SampleDB.db");
        }
    }

    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
