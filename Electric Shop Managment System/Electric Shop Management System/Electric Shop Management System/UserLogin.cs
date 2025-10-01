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
    public partial class UserLogin : Form
    {
        private DataAccess Da { get; set; }
        public UserLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from users where userid=" + this.txtUserID.Text +
                            " and password = '" + this.txtPassword.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var name = dt.Rows[0][1].ToString();
                    MessageBox.Show("Valid User");
                    this.Hide();

                    if (dt.Rows[0][3].ToString() == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else if (dt.Rows[0][3].ToString().Equals("Salesman"))
                    {
                        Salesman salesman = new Salesman();
                        salesman.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

       
       
    }
}
