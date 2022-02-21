using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem
{
    public class ClientContext : DbContext
    {
        DbSet<Client> Client { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder _dbContextOptionsBuilder)
        {
            _dbContextOptionsBuilder.UseSqlite("data source=SampleDB.db");
        }
    }

    public class Client
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string BillingAddress { get; set; }
        public string City { get; set; }
        public string Disrict { get; set; }
        public string PinCode { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public double OpeiningBalance { get; set; }
        public bool CreditAllowed { get; set; }
        public string Type { get; set; }
        public double CreditLimit { get; set; }
    }
}
