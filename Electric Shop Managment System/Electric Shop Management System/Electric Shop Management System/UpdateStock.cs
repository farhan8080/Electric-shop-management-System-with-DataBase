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
    public partial class UpdateStock : Form
    {
        private DataAccess Da { get; set; }
        public UpdateStock()
        {
            InitializeComponent();
            this.Da =new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate1();
           
           
        }

        private void PopulateGridView(string sql = "select * from Stock")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUpdateStock.AutoGenerateColumns = false;
            this.dgvUpdateStock.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate1()
        {
            var query1 = "select isnull(max(StockID), 0) from stock";
           
            var dt1 = this.Da.ExecuteQueryTable(query1);
           

            int oldId1 = Convert.ToInt32(dt1.Rows[0][0]);
            int newId1 = oldId1 + 1;

           

            
            this.txtStockID.Text = newId1.ToString();
        }
       


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Salesman salesman = new Salesman(); 
             salesman.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from stock where StockID ='" + this.txtStockID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Stock
                                set 
                                ProductID = " + this.txtProductID.Text + @",
                                Quantity = " + this.txtQuantity.Text + @",
                                StockInDate = '" + this.dtpStockInDate.Text + @"'
                               
                                where StockID = '" + this.txtStockID.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    var sql = "INSERT INTO Stock VALUES ('"+this.txtStockID.Text+"', '"+this.txtProductID.Text+"', '"+this.txtQuantity.Text+"', '"+this.dtpStockInDate.Text+"');";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added");
                    else
                        MessageBox.Show("Data hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductID.Text) || string.IsNullOrEmpty(this.txtStockID.Text) ||
                string.IsNullOrEmpty(this.txtQuantity.Text)  )
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtStockID.Clear();
            this.txtProductID.Clear();
            this.txtQuantity.Clear();
           
            this.dtpStockInDate.Text = "";
            

           
          

            this.dgvUpdateStock.ClearSelection();
            this.AutoIdGenerate1();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvUpdateStock_DoubleClick(object sender, EventArgs e)
        {
            this.txtStockID.Text = this.dgvUpdateStock.CurrentRow.Cells[0].Value.ToString();
            this.txtProductID.Text = this.dgvUpdateStock.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvUpdateStock.CurrentRow.Cells[2].Value.ToString();
            
            this.dtpStockInDate.Text = this.dgvUpdateStock.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
}
