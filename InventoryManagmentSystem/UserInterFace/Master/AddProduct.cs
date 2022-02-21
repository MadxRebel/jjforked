using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        DataAccess.SqliteDataAccess da = new DataAccess.SqliteDataAccess();
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            
            Product pr = new Product
            {
                ItemCode = "1",
                ProductName = "Dell Laptop",
                ProductType = "General",


            };

            List<Product> list = da.LoadData<Product, dynamic>("Select * From Product;", new { }).ToList();
            
            foreach (var item in list)
            {
                MessageBox.Show(item.ProductName);
            }
            //da.SaveData("insert into Product(ItemCode, ProductName, ProductType) values(@ItemCode, @ProductName, @ProductType)", new { pr.ItemCode, pr.ProductName, pr.ProductType });
        }

        private void txtBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Return)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
