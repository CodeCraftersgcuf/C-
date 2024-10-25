namespace UserControlApp
{
    partial class Form1
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
            this.groupedControl1 = new CompositeLibrary.GroupedControl();
            this.customButton1 = new CustomLibrary.CustomButton();
            this.dataGridControl1 = new UserLibrary.DataGridControl();
            this.SuspendLayout();
            // 
            // groupedControl1
            // 
            this.groupedControl1.Location = new System.Drawing.Point(-370, -63);
            this.groupedControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupedControl1.Name = "groupedControl1";
            this.groupedControl1.Size = new System.Drawing.Size(819, 554);
            this.groupedControl1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.ButtonText = "Custom Button";
            this.customButton1.Location = new System.Drawing.Point(-387, 175);
            this.customButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(700, 178);
            this.customButton1.TabIndex = 1;
            // 
            // dataGridControl1
            // 
            this.dataGridControl1.Location = new System.Drawing.Point(-440, 361);
            this.dataGridControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridControl1.Name = "dataGridControl1";
            this.dataGridControl1.Size = new System.Drawing.Size(855, 380);
            this.dataGridControl1.TabIndex = 2;
            this.dataGridControl1.Load += new System.EventHandler(this.dataGridControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 702);
            this.Controls.Add(this.dataGridControl1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.groupedControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CompositeLibrary.GroupedControl groupedControl1;
        private CustomLibrary.CustomButton customButton1;
        private UserLibrary.DataGridControl dataGridControl1;
    }
}

