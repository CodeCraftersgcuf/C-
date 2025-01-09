namespace SalesManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantitySold;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.TextBox txtTotalSaleAmount;
        private System.Windows.Forms.Button btnRecordSale;
        private System.Windows.Forms.Button btnRetrieveSales;
        private System.Windows.Forms.Button btnCalculateTotalSales;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label lblTotalSaleAmount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantitySold = new System.Windows.Forms.TextBox();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.txtTotalSaleAmount = new System.Windows.Forms.TextBox();
            this.btnRecordSale = new System.Windows.Forms.Button();
            this.btnRetrieveSales = new System.Windows.Forms.Button();
            this.btnCalculateTotalSales = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.lblTotalSaleAmount = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblProductID.Text = "Product ID:";
            this.lblProductID.Location = new System.Drawing.Point(12, 15);
            this.lblQuantitySold.Text = "Quantity Sold:";
            this.lblQuantitySold.Location = new System.Drawing.Point(12, 45);
            this.lblSaleDate.Text = "Sale Date:";
            this.lblSaleDate.Location = new System.Drawing.Point(12, 75);
            this.lblTotalSaleAmount.Text = "Total Sale Amount:";
            this.lblTotalSaleAmount.Location = new System.Drawing.Point(12, 105);

            // TextBoxes
            this.txtProductID.Location = new System.Drawing.Point(150, 12);
            this.txtQuantitySold.Location = new System.Drawing.Point(150, 42);
            this.txtSaleDate.Location = new System.Drawing.Point(150, 72);
            this.txtTotalSaleAmount.Location = new System.Drawing.Point(150, 102);

            // Buttons
            this.btnRecordSale.Text = "Record Sale";
            this.btnRecordSale.Location = new System.Drawing.Point(12, 140);
            this.btnRecordSale.Click += new System.EventHandler(this.btnRecordSale_Click);

            this.btnRetrieveSales.Text = "Retrieve Sales";
            this.btnRetrieveSales.Location = new System.Drawing.Point(150, 140);
            this.btnRetrieveSales.Click += new System.EventHandler(this.btnRetrieveSales_Click);

            this.btnCalculateTotalSales.Text = "Calculate Total Sales";
            this.btnCalculateTotalSales.Location = new System.Drawing.Point(288, 140);
            this.btnCalculateTotalSales.Click += new System.EventHandler(this.btnCalculateTotalSales_Click);

            // DataGridView
            this.dgvSales.Location = new System.Drawing.Point(12, 180);
            this.dgvSales.Size = new System.Drawing.Size(760, 250);

            // Form Layout
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtQuantitySold);
            this.Controls.Add(this.txtSaleDate);
            this.Controls.Add(this.txtTotalSaleAmount);
            this.Controls.Add(this.btnRecordSale);
            this.Controls.Add(this.btnRetrieveSales);
            this.Controls.Add(this.btnCalculateTotalSales);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblQuantitySold);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.lblTotalSaleAmount);
            this.Text = "Sales Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
