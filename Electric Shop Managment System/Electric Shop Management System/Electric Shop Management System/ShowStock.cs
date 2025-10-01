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
    public partial class ShowStock : Form
    {
        private DataAccess Da {  get; set; }     
        public ShowStock()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           this. PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from stock")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShowStock.AutoGenerateColumns = false;
            this.dgvShowStock.DataSource = ds.Tables[0];
        }

        private void txtAutoSearchStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from Stock where StockID like '" + this.txtAutoSearchStock.Text + "%';";
                PopulateGridView(sql);
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

        private void dgvShowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
