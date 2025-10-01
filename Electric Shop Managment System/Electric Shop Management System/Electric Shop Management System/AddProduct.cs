using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_Shop_Management_System
{
    public partial class AddProduct : Form
    {
        private DataAccess Da { get; set; }
        public AddProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
           
        }

        private void PopulateGridView(string sql = "select * from Products;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShowProduct.AutoGenerateColumns = false;
            this.dgvShowProduct.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Salesman salesman = new Salesman();
            salesman.Show();
        }

        

        private void dgvShowProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductID.Text = this.dgvShowProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvShowProduct.CurrentRow.Cells[1].Value.ToString();
            this.txtCategoryID.Text = this.dgvShowProduct.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dgvShowProduct.CurrentRow.Cells[3].Value.ToString();
            this.txtDescription.Text = this.dgvShowProduct.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.dgvShowProduct.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the  fields");
                    return;
                }

                var query = "select * from Products where ProductID ='" + this.txtProductID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Products
                                ProductName = '" + this.txtProductName.Text + @"',
                                 CategoryID = " + this.txtCategoryID.Text + @",
                                Price = " + this.txtPrice.Text + @",
                                Description= '" + this.txtDescription.Text + @"'
                                where ProductID = '" + this.txtProductID.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    string sql = "INSERT INTO Products VALUES('" + this.txtProductID.Text + "', '" +
              this.txtProductName.Text + "', " + this.txtCategoryID.Text + ", " +
              this.txtPrice.Text + ", '" + this.txtDescription.Text + "');";
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
                MessageBox.Show("There are an error: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txtProductID.Clear();
            this.txtProductName.Clear();
            this.txtCategoryID.Clear();
            this.txtPrice.Clear();
            this.txtDescription.Clear();
            this.dgvShowProduct.ClearSelection();

            this.txtAutoSearch.Text = "";

            this.dgvShowProduct.ClearSelection();
            this.AutoIdGenerate();

        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductID.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.txtCategoryID.Text) || string.IsNullOrEmpty(this.txtPrice.Text) ||
                string.IsNullOrEmpty(this.txtDescription.Text))
                return false;
            else
                return true;
        }
        private void AutoIdGenerate()
        {
            var query = "select isnull(max(ProductID), 0) from Products;";
            var dt = this.Da.ExecuteQueryTable(query);

            int oldId = Convert.ToInt32(dt.Rows[0][0]);
            int newId = oldId + 1;

            this.txtProductID.Text = newId.ToString();
        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShowProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                var id = this.dgvShowProduct.CurrentRow.Cells[0].Value.ToString();
                var Name= this.dgvShowProduct.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + Name + "?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Products where ProductID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Products where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
   }

