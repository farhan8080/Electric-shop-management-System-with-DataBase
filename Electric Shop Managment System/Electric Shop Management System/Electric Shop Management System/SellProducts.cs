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

    public partial class SellProducts : Form
    {
        private DataAccess Da { get; set; }
        private DataTable cartTable;

        public SellProducts()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.InitializeCart();
            this.LoadCategories();
            this.LoadAllProducts();
            this.AutoIdGenerate();

        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ProductID");
            cartTable.Columns.Add("ProductName");
            cartTable.Columns.Add("UnitPrice", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("TotalPrice", typeof(decimal));

            dgvCart.DataSource = cartTable;

            // dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            txtSearch.Text = "";
            cmbCategory.SelectedIndex = -1;
        }

        private void LoadAllProducts()
        {
            try
            {
                dgvProducts.AutoGenerateColumns = true;

                string sql = @"
            SELECT 
                p.ProductID, 
                p.ProductName, 
                c.CategoryName, 
                p.Price,
                ISNULL(SUM(s.Quantity), 0) AS StockQuantity
            FROM Products p
            JOIN Categories c ON p.CategoryID = c.CategoryID
            LEFT JOIN Stock s ON p.ProductID = s.ProductID
            GROUP BY p.ProductID, p.ProductName, c.CategoryName, p.Price";

                var dt = this.Da.ExecuteQueryTable(sql);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all products: " + ex.Message);
            }


            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["StockQuantity"].Value != null)
                {
                    int stock = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                    if (stock <= 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        private void ReduceStock(string productId, int quantity)
        {
            string sql = $@"
        UPDATE Stock
        SET Quantity = Quantity - {quantity}
        WHERE ProductID = {productId};";

            Da.ExecuteDMLQuery(sql); // Assuming this method executes non-query SQL
        }
        private void LoadCategories()
        {
            var sql = "SELECT CategoryID, CategoryName FROM Categories;";
            var dt = this.Da.ExecuteQueryTable(sql);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = dt;
        }

        private void FilterProducts()
        {
            try
            {
                dgvProducts.AutoGenerateColumns = true;

                string search = txtSearch.Text.Trim();
                string categoryId = cmbCategory.SelectedValue?.ToString();

                // Base query with WHERE before GROUP BY
                string sql = @"
SELECT 
    p.ProductID, 
    p.ProductName, 
    c.CategoryName, 
    p.Price,
    ISNULL(SUM(s.Quantity), 0) AS StockQuantity
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
LEFT JOIN Stock s ON p.ProductID = s.ProductID
WHERE 1=1"; // Always true, makes appending filters easier

                if (!string.IsNullOrEmpty(search))
                    sql += $" AND p.ProductName LIKE '{search}%'";

                if (!string.IsNullOrEmpty(categoryId))
                    sql += $" AND p.CategoryID = {categoryId}";

                sql += @"
                 GROUP BY p.ProductID, p.ProductName, c.CategoryName, p.Price";

                var dt = this.Da.ExecuteQueryTable(sql);
                dgvProducts.DataSource = dt;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }


        private int GetAvailableStock(string productId)
        {
            string sql = $"SELECT Quantity FROM Stock WHERE ProductID = {productId};";
            var dt = Da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["Quantity"]);

            return 0;
        }


        private void UpdateCartTotal()
        {
            decimal total = cartTable.AsEnumerable()
                .Sum(row => row.Field<decimal>("TotalPrice"));
            lblTotalAmount.Text = $"Total: {total:C}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Salesman salesman = new Salesman();
            salesman.Show();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (txtQuantityToAdd.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            string productId = dgvProducts.CurrentRow.Cells["ProductID"].Value.ToString();
            string productName = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            decimal unitPrice = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Price"].Value);
            int quantityToAdd = Convert.ToInt32(txtQuantityToAdd.Value);

            int availableStock = GetAvailableStock(productId);

            int alreadyInCart = cartTable.AsEnumerable()
                .Where(row => row["ProductID"].ToString() == productId)
                .Sum(row => row.Field<int>("Quantity"));

            if (quantityToAdd > availableStock)
            {
                MessageBox.Show($"Only {availableStock} units available in stock.");
                return;
            }

            var existingRow = cartTable.AsEnumerable()
                .FirstOrDefault(row => row["ProductID"].ToString() == productId);

            if (existingRow != null)
            {
                int currentQty = Convert.ToInt32(existingRow["Quantity"]);
                existingRow["Quantity"] = currentQty + quantityToAdd;
                existingRow["TotalPrice"] = unitPrice * (currentQty + quantityToAdd);
            }
            else
            {
                cartTable.Rows.Add(productId, productName, unitPrice, quantityToAdd, unitPrice * quantityToAdd);
            }

            ReduceStock(productId, quantityToAdd);

            UpdateCartTotal();
            LoadAllProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.FilterProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilterProducts();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item in the cart to remove.");
                return;
            }

            foreach (DataGridViewRow row in dgvCart.SelectedRows)
            {
                string productId = row.Cells["ProductID"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Restore stock
                string sql = $@"
            UPDATE Stock
            SET Quantity = Quantity + {quantity}
            WHERE ProductID = {productId};";
                Da.ExecuteDMLQuery(sql);

                dgvCart.Rows.Remove(row);
            }

            UpdateCartTotal();
            LoadAllProducts();
        }
        private void AutoIdGenerate()
        {
            var query = "select isnull(max(saleID), 0) from sales;";
            var dt = this.Da.ExecuteQueryTable(query);

            int oldId = Convert.ToInt32(dt.Rows[0][0]);
            int newId = oldId + 1;

            this.txtsaleID.Text = newId.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            decimal totalAmount = cartTable.AsEnumerable()
                .Sum(row => row.Field<decimal>("TotalPrice"));

            string saleDate = DateTime.Now.ToString("yyyy-MM-dd");

            string sql = $@"
        INSERT INTO Sales (saleID,SaleDate, CustomerName, TotalPrice)
        VALUES ('{this.txtsaleID.Text}','{saleDate}', '{customerName}', '{totalAmount}');";

            Da.ExecuteDMLQuery(sql);

            MessageBox.Show("Sale recorded successfully!");

            cartTable.Clear();
            UpdateCartTotal();
            LoadAllProducts();

            SalesmanShowSale showSale = new SalesmanShowSale();
            showSale.Show();
            this.Close();
        }
    }
}
