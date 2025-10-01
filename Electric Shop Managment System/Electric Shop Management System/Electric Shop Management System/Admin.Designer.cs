namespace Electric_Shop_Management_System
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbShowSales = new System.Windows.Forms.Label();
            this.lbShowCategory = new System.Windows.Forms.Label();
            this.lbShowStock = new System.Windows.Forms.Label();
            this.lbUserList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 869);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(505, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbShowSales);
            this.panel2.Controls.Add(this.lbShowCategory);
            this.panel2.Controls.Add(this.lbShowStock);
            this.panel2.Controls.Add(this.lbUserList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 869);
            this.panel2.TabIndex = 5;
            // 
            // lbShowSales
            // 
            this.lbShowSales.AutoSize = true;
            this.lbShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowSales.Location = new System.Drawing.Point(77, 661);
            this.lbShowSales.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowSales.Name = "lbShowSales";
            this.lbShowSales.Size = new System.Drawing.Size(158, 30);
            this.lbShowSales.TabIndex = 4;
            this.lbShowSales.Text = "Show Sales";
            this.lbShowSales.Click += new System.EventHandler(this.lbShowSales_Click);
            // 
            // lbShowCategory
            // 
            this.lbShowCategory.AutoSize = true;
            this.lbShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowCategory.Location = new System.Drawing.Point(79, 554);
            this.lbShowCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowCategory.Name = "lbShowCategory";
            this.lbShowCategory.Size = new System.Drawing.Size(201, 30);
            this.lbShowCategory.TabIndex = 3;
            this.lbShowCategory.Text = "Show Category";
            this.lbShowCategory.Click += new System.EventHandler(this.lbShowCategory_Click);
            // 
            // lbShowStock
            // 
            this.lbShowStock.AutoSize = true;
            this.lbShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowStock.Location = new System.Drawing.Point(79, 454);
            this.lbShowStock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowStock.Name = "lbShowStock";
            this.lbShowStock.Size = new System.Drawing.Size(158, 30);
            this.lbShowStock.TabIndex = 2;
            this.lbShowStock.Text = "Show Stock";
            this.lbShowStock.Click += new System.EventHandler(this.lbShowStock_Click);
            // 
            // lbUserList
            // 
            this.lbUserList.AutoSize = true;
            this.lbUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserList.Location = new System.Drawing.Point(77, 242);
            this.lbUserList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserList.Name = "lbUserList";
            this.lbUserList.Size = new System.Drawing.Size(191, 30);
            this.lbUserList.TabIndex = 0;
            this.lbUserList.Text = "Add New User";
            this.lbUserList.Click += new System.EventHandler(this.lbUserList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show Product List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1244, 733);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 87);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(620, 19);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(368, 44);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Welcome To Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 865);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbShowSales;
        private System.Windows.Forms.Label lbShowCategory;
        private System.Windows.Forms.Label lbShowStock;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}