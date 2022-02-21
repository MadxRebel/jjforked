using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem
{
    public class UnitContext: DbContext
    {
        DbSet<Unit> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder _dbContextOptionsBuilder)
        {
            _dbContextOptionsBuilder.UseSqlite("data source=SampleDB.db");
        }
    }

    public class Unit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
    }
}
