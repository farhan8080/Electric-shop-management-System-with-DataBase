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
    public partial class ShowProduct : Form
    {
        private DataAccess Da { get; set; }

        public ShowProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Products")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShowProduct.AutoGenerateColumns = false;
            this.dgvShowProduct.DataSource = ds.Tables[0];
        }
       

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var sql = "select * from Products where ProductName like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Admin admin = new Admin();
            admin.Show();
            this.Close();


        }
    }
}
