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
    public partial class ShowCategory : Form
    {
        private DataAccess Da { get; set; }
        public ShowCategory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Categories")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.DataSource = ds.Tables[0];
        }

        private void txtAutoSearchCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from Categories where CategoryID like '"+this.txtAutoSearchCategory.Text+"%'";
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
    }
}
