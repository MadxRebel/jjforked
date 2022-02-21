using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem
{
    public class ProductContext: DbContext
    {
        DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder _dbContextOptionsBuilder)
        {
            _dbContextOptionsBuilder.UseSqlite("data source=SampleDB.db");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public string PrintName { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public double MinSalePrice { get; set; }
        public string Unit { get; set; }
        public int OpeiningStock { get; set; }
        public int OpeningStockVal { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public string SerialNo { get; set; }
    }
}
