namespace Electric_Shop_Management_System
{
    partial class UpdateStock
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUpdateStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStockID = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStockInDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1282, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 73);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<--Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUpdateStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 471);
            this.panel1.TabIndex = 1;
            // 
            // dgvUpdateStock
            // 
            this.dgvUpdateStock.AllowUserToAddRows = false;
            this.dgvUpdateStock.AllowUserToDeleteRows = false;
            this.dgvUpdateStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ProductID,
            this.Quantity,
            this.StockInDate});
            this.dgvUpdateStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUpdateStock.Location = new System.Drawing.Point(0, 0);
            this.dgvUpdateStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUpdateStock.Name = "dgvUpdateStock";
            this.dgvUpdateStock.ReadOnly = true;
            this.dgvUpdateStock.RowHeadersWidth = 82;
            this.dgvUpdateStock.RowTemplate.Height = 33;
            this.dgvUpdateStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdateStock.Size = new System.Drawing.Size(1444, 471);
            this.dgvUpdateStock.TabIndex = 0;
            this.dgvUpdateStock.DoubleClick += new System.EventHandler(this.dgvUpdateStock_DoubleClick);
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
            // lbStockID
            // 
            this.lbStockID.AutoSize = true;
            this.lbStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockID.Location = new System.Drawing.Point(240, 44);
            this.lbStockID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStockID.Name = "lbStockID";
            this.lbStockID.Size = new System.Drawing.Size(110, 29);
            this.lbStockID.TabIndex = 2;
            this.lbStockID.Text = "Stock ID";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(436, 44);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.ReadOnly = true;
            this.txtStockID.Size = new System.Drawing.Size(252, 35);
            this.txtStockID.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(436, 127);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(252, 35);
            this.txtProductID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product ID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(436, 213);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(252, 35);
            this.txtQuantity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(942, 44);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 69);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(942, 181);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 69);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1132, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 25);
            this.label8.TabIndex = 120;
            this.label8.Text = "Double click a row to update";
            // 
            // dtpStockInDate
            // 
            this.dtpStockInDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStockInDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStockInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockInDate.Location = new System.Drawing.Point(436, 300);
            this.dtpStockInDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpStockInDate.Name = "dtpStockInDate";
            this.dtpStockInDate.Size = new System.Drawing.Size(264, 31);
            this.dtpStockInDate.TabIndex = 121;
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 852);
            this.Controls.Add(this.dtpStockInDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.lbStockID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUpdateStock;
        private System.Windows.Forms.Label lbStockID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInDate;
        private System.Windows.Forms.DateTimePicker dtpStockInDate;
    }
}