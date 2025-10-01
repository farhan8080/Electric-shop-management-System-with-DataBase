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
    public partial class SalesmanShowSale : Form
    {
        private DataAccess Da { get; set; }
        public SalesmanShowSale()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowSale showSale = new ShowSale();
            showSale.Show();
            this.Close();
        }
        private void PopulateGridView(string sql = "select * from Sales")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.DataSource = ds.Tables[0];
        }

        private void txtAutoSearchSale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from Sales where SaleID like '" + this.txtAutoSearchSale.Text + "%'";
                PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
