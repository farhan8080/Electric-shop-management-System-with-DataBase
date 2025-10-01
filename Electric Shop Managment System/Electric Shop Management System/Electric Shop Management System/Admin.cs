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
    public partial class Admin : Form
    {
       // public UserLogin Fl { get; set; }

        public Admin()
        {
            InitializeComponent();
        }
        //public Admin(string name, UserLogin fl) : this()
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

        private void lbUserList_Click(object sender, EventArgs e)
        {
            ShowUser showUser = new ShowUser();
            showUser.Show();
            this.Close();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowProduct showProduct = new ShowProduct();    
            showProduct.Show();
            this.Close();
        }

        private void lbShowStock_Click(object sender, EventArgs e)
        {
            
            ShowStock showStock = new ShowStock();
            showStock.Show();
            this.Close();
        }

        private void lbShowCategory_Click(object sender, EventArgs e)
        {
            ShowCategory  showCategory = new ShowCategory();
            showCategory.Show();
            this.Close();
        }

        private void lbShowSales_Click(object sender, EventArgs e)
        {
            ShowSale showSale = new ShowSale(); 
            showSale.Show();
            this.Close();
        }

      
    }
}
