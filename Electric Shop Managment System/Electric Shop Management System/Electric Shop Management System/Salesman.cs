using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_Shop_Management_System
{
    public partial class Salesman : Form
    {
      // public UserLogin Fl { get; set; }
        public Salesman()
        {
            InitializeComponent();
        }
        //public Salesman(string name, UserLogin fl) : this()
        //{
        //    this.lblInfo.Text += name;
        //    this.Fl = fl;
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //MessageBox.Show("Logged out from the system");
            //this.Fl.Visible = true;

            this.Close();
            MessageBox.Show("Logged out from the system");
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

        private void lbAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
            this.Close();
        }

        private void lbUpdatestockinformation_Click(object sender, EventArgs e)
        {
            UpdateStock updateStock = new UpdateStock();
            updateStock.Show();
            this.Close();
        }

        private void lbaddnewcategories_Click(object sender, EventArgs e)
        {
            AddNewCategories product = new AddNewCategories();
            product.Show();
            this.Close();
        }

        private void lboSellproducts_Click(object sender, EventArgs e)
        {
            SellProducts sellProducts = new SellProducts();
            sellProducts.Show();
            this.Close();
        }
    }
}
