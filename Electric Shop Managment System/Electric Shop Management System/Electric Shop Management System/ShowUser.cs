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
    public partial class ShowUser : Form
    {
        private DataAccess Da { get; set; }
        public ShowUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
           this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Users")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShowUser.AutoGenerateColumns = false;
            this.dgvShowUser.DataSource = ds.Tables[0];
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

                var query = "select * from Users where UserID ='" + this.txtUserID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Users
                        set Username = '" + this.txtUsername.Text + @"',
                            Password = '" + this.txtPassword.Text + @"',
                            Role = '" + this.cmbRole.Text + @"'
                        where UserID = '" + this.txtUserID.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    var sql = "insert into Users values('" + this.txtUserID.Text + "', '" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "');";
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
            if (string.IsNullOrEmpty(this.txtUserID.Text) || string.IsNullOrEmpty(this.txtUsername.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text)  ||
                string.IsNullOrEmpty(this.cmbRole.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbRole.SelectedIndex = -1;
            this.txtAutoSearch.Text = "";
            this.dgvShowUser.ClearSelection();
            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var query = "select isnull(max(UserID), 0) from Users;";
            var dt = this.Da.ExecuteQueryTable(query);

            int oldId = Convert.ToInt32(dt.Rows[0][0]); 
            int newId = oldId + 1;

            this.txtUserID.Text = newId.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShowUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvShowUser.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvShowUser.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Users where UserID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title + " has been removed from the list");
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

        private void dgvShowUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserID.Text = this.dgvShowUser.CurrentRow.Cells[0].Value.ToString();
            this.txtUsername.Text = this.dgvShowUser.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvShowUser.CurrentRow.Cells[2].Value.ToString();
            this.cmbRole.Text = this.dgvShowUser.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
              var sql = "select * from Users where Username like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

       
    }
}
