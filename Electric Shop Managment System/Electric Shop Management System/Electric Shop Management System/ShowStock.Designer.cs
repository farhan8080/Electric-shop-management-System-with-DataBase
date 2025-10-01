namespace Electric_Shop_Management_System
{
    partial class ShowStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoSearchStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShowStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 529);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvShowStock
            // 
            this.dgvShowStock.AllowUserToAddRows = false;
            this.dgvShowStock.AllowUserToDeleteRows = false;
            this.dgvShowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ProductID,
            this.Quantity,
            this.StockInDate});
            this.dgvShowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowStock.Location = new System.Drawing.Point(0, 0);
            this.dgvShowStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowStock.Name = "dgvShowStock";
            this.dgvShowStock.ReadOnly = true;
            this.dgvShowStock.RowHeadersWidth = 82;
            this.dgvShowStock.RowTemplate.Height = 33;
            this.dgvShowStock.Size = new System.Drawing.Size(1384, 529);
            this.dgvShowStock.TabIndex = 0;
            this.dgvShowStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowStock_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.MinimumWidth = 10;
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Width = 200;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 10;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 200;
            // 
            // StockInDate
            // 
            this.StockInDate.DataPropertyName = "StockInDate";
            this.StockInDate.HeaderText = "StockInDate";
            this.StockInDate.MinimumWidth = 10;
            this.StockInDate.Name = "StockInDate";
            this.StockInDate.ReadOnly = true;
            this.StockInDate.Width = 200;
            // 
            // txtAutoSearchStock
            // 
            this.txtAutoSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchStock.Location = new System.Drawing.Point(710, 94);
            this.txtAutoSearchStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearchStock.Name = "txtAutoSearchStock";
            this.txtAutoSearchStock.Size = new System.Drawing.Size(294, 35);
            this.txtAutoSearchStock.TabIndex = 1;
            this.txtAutoSearchStock.TextChanged += new System.EventHandler(this.txtAutoSearchStock_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Stock Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1208, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 67);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<<--Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 823);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutoSearchStock);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowStock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowStock;
        private System.Windows.Forms.TextBox txtAutoSearchStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInDate;
    }
}