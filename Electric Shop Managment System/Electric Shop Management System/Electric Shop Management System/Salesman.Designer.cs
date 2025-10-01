namespace Electric_Shop_Management_System
{
    partial class Salesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salesman));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboSellproducts = new System.Windows.Forms.Label();
            this.lbaddnewcategories = new System.Windows.Forms.Label();
            this.lbUpdatestockinformation = new System.Windows.Forms.Label();
            this.lbAddProduct = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(587, 21);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(454, 44);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome  To  Salesman";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1274, 750);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 92);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lboSellproducts);
            this.panel1.Controls.Add(this.lbaddnewcategories);
            this.panel1.Controls.Add(this.lbUpdatestockinformation);
            this.panel1.Controls.Add(this.lbAddProduct);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 858);
            this.panel1.TabIndex = 2;
            // 
            // lboSellproducts
            // 
            this.lboSellproducts.AutoSize = true;
            this.lboSellproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboSellproducts.Location = new System.Drawing.Point(58, 567);
            this.lboSellproducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lboSellproducts.Name = "lboSellproducts";
            this.lboSellproducts.Size = new System.Drawing.Size(174, 30);
            this.lboSellproducts.TabIndex = 3;
            this.lboSellproducts.Text = "Sell products";
            this.lboSellproducts.Click += new System.EventHandler(this.lboSellproducts_Click);
            // 
            // lbaddnewcategories
            // 
            this.lbaddnewcategories.AutoSize = true;
            this.lbaddnewcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddnewcategories.Location = new System.Drawing.Point(58, 458);
            this.lbaddnewcategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbaddnewcategories.Name = "lbaddnewcategories";
            this.lbaddnewcategories.Size = new System.Drawing.Size(263, 30);
            this.lbaddnewcategories.TabIndex = 2;
            this.lbaddnewcategories.Text = "Add new categories ";
            this.lbaddnewcategories.Click += new System.EventHandler(this.lbaddnewcategories_Click);
            // 
            // lbUpdatestockinformation
            // 
            this.lbUpdatestockinformation.AutoSize = true;
            this.lbUpdatestockinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdatestockinformation.Location = new System.Drawing.Point(58, 337);
            this.lbUpdatestockinformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUpdatestockinformation.Name = "lbUpdatestockinformation";
            this.lbUpdatestockinformation.Size = new System.Drawing.Size(320, 30);
            this.lbUpdatestockinformation.TabIndex = 1;
            this.lbUpdatestockinformation.Text = "Update stock Information";
            this.lbUpdatestockinformation.Click += new System.EventHandler(this.lbUpdatestockinformation_Click);
            // 
            // lbAddProduct
            // 
            this.lbAddProduct.AutoSize = true;
            this.lbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddProduct.Location = new System.Drawing.Point(58, 206);
            this.lbAddProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddProduct.Name = "lbAddProduct";
            this.lbAddProduct.Size = new System.Drawing.Size(178, 30);
            this.lbAddProduct.TabIndex = 0;
            this.lbAddProduct.Text = "Add Products";
            this.lbAddProduct.Click += new System.EventHandler(this.lbAddProduct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(531, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 865);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblInfo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Salesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lboSellproducts;
        private System.Windows.Forms.Label lbaddnewcategories;
        private System.Windows.Forms.Label lbUpdatestockinformation;
        private System.Windows.Forms.Label lbAddProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}