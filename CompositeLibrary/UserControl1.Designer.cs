namespace CompositeLibrary
{
    partial class GroupedControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Button);
            this.GroupBox.Controls.Add(this.TextBox);
            this.GroupBox.Controls.Add(this.Label);
            this.GroupBox.Location = new System.Drawing.Point(335, 67);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(200, 129);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "groupBox1";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(6, 30);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(151, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "Example of Composite";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(6, 57);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(170, 20);
            this.TextBox.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button.Location = new System.Drawing.Point(6, 96);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 27);
            this.Button.TabIndex = 2;
            this.Button.Text = "Save";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // GroupedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.Name = "GroupedControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.GroupedControl_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label;

        
    }
}
