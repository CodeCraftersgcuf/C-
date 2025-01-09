using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=ABUBAKAR\\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductID.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantitySold.Text, out int quantitySold))
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(txtSaleDate.Text, out DateTime saleDate))
            {
                MessageBox.Show("Invalid Sale Date. Please enter a valid date (e.g., 2025-01-09).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTotalSaleAmount.Text, out decimal totalSaleAmount))
            {
                MessageBox.Show("Invalid Total Sale Amount. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Sales (ProductID, QuantitySold, SaleDate, TotalSaleAmount) VALUES (@ProductID, @QuantitySold, @SaleDate, @TotalSaleAmount)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                    cmd.Parameters.AddWithValue("@SaleDate", saleDate);
                    cmd.Parameters.AddWithValue("@TotalSaleAmount", totalSaleAmount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale recorded successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bro That Product You are trying to add does not exist.");
            }
        }

        private void btnRetrieveSales_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductID.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Sales WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvSales.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An errors occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateTotalSales_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductID.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT SUM(TotalSaleAmount) AS TotalSales FROM Sales WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    decimal totalSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    MessageBox.Show($"Total Sales for Product {productId}: {totalSales:C}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An errors occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
