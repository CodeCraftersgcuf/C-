using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProductSalesViewer
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=ABUBAKAR\\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Function to Get Product Sales Data from Database
        private DataTable GetProductSalesData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Adjusted query to join Sales and Products tables
                string query = @"
                    SELECT 
                        s.ProductID, 
                        p.ProductName, 
                        s.QuantitySold, 
                        s.SaleDate, 
                        p.UnitPrice,
                        s.TotalSaleAmount
                    FROM 
                        Sales s
                    INNER JOIN 
                        Products p ON s.ProductID = p.ProductID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable salesData = new DataTable();
                adapter.Fill(salesData);
                return salesData;
            }
        }

        // LINQ Query to Process Data
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            var salesData = GetProductSalesData();

            // Convert DataTable to IEnumerable for LINQ
            var query = from row in salesData.AsEnumerable()
                        group row by new
                        {
                            ProductId = row.Field<int>("ProductID"),
                            ProductName = row.Field<string>("ProductName"),
                            SaleDate = row.Field<DateTime>("SaleDate")
                        } into grouped
                        select new
                        {
                            ProductId = grouped.Key.ProductId,
                            ProductName = grouped.Key.ProductName,
                            SaleDate = grouped.Key.SaleDate,
                            QuantitySold = grouped.Sum(r => r.Field<int>("QuantitySold")),
                            TotalSaleAmount = grouped.Sum(r => r.Field<decimal>("TotalSaleAmount"))
                        };

            // Bind the query result to DataGridView
            dgvProductSales.DataSource = query.ToList();
        }
    }
}
