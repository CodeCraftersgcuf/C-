namespace ProductSalesViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductSales;
        private System.Windows.Forms.Button btnLoadData;

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
            this.dgvProductSales = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSales)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvProductSales
            // 
            this.dgvProductSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSales.Location = new System.Drawing.Point(12, 50);
            this.dgvProductSales.Name = "dgvProductSales";
            this.dgvProductSales.Size = new System.Drawing.Size(760, 300);
            this.dgvProductSales.TabIndex = 0;

            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 32);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvProductSales);
            this.Name = "Form1";
            this.Text = "Product Sales Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSales)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
