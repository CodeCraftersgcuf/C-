using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Declare a variable to store memory value
        private double memoryValue = 0;

        // Code for the buttons' functionality (to be added in a later step)
        // ...
    }

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button btnBackspace, btnCE, btnC;
        private System.Windows.Forms.Button btn7, btn8, btn9, btnDivide;
        private System.Windows.Forms.Button btn4, btn5, btn6, btnMultiply;
        private System.Windows.Forms.Button btn1, btn2, btn3, btnMinus;
        private System.Windows.Forms.Button btn0, btnDecimal, btnPlus, btnEquals;
        private System.Windows.Forms.Button btnSqrt, btnReciprocal, btnPlusMinus;
        private System.Windows.Forms.Button btnMPlus, btnMMinus, btnMR, btnMC;

        private void InitializeComponent()
        {
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Display TextBox
            this.DisplayTextBox.Font = new System.Drawing.Font("Arial", 18F);
            this.DisplayTextBox.Location = new System.Drawing.Point(10, 10);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(290, 35);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Backspace Button
            this.btnBackspace.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBackspace.Location = new System.Drawing.Point(70, 55);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(55, 40);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.BackColor = System.Drawing.Color.LightBlue; // Changed color

            // CE Button
            this.btnCE.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCE.Location = new System.Drawing.Point(130, 55);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(55, 40);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.BackColor = System.Drawing.Color.LightCoral; // Changed color

            // C Button
            this.btnC.Font = new System.Drawing.Font("Arial", 12F);
            this.btnC.Location = new System.Drawing.Point(190, 55);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(55, 40);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.BackColor = System.Drawing.Color.LightGreen; // Changed color

            // Sqrt Button
            this.btnSqrt.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSqrt.Location = new System.Drawing.Point(250, 55);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(55, 40);
            this.btnSqrt.TabIndex = 4;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.BackColor = System.Drawing.Color.LightYellow; // Changed color

            // Number 7 Button
            this.btn7.Font = new System.Drawing.Font("Arial", 12F);
            this.btn7.Location = new System.Drawing.Point(70, 105);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 40);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 8 Button
            this.btn8.Font = new System.Drawing.Font("Arial", 12F);
            this.btn8.Location = new System.Drawing.Point(130, 105);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 40);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 9 Button
            this.btn9.Font = new System.Drawing.Font("Arial", 12F);
            this.btn9.Location = new System.Drawing.Point(190, 105);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 40);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Divide Button
            this.btnDivide.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDivide.Location = new System.Drawing.Point(250, 105);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 40);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.BackColor = System.Drawing.Color.LightGoldenrodYellow; // Changed color

            // Number 4 Button
            this.btn4.Font = new System.Drawing.Font("Arial", 12F);
            this.btn4.Location = new System.Drawing.Point(70, 155);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 40);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 5 Button
            this.btn5.Font = new System.Drawing.Font("Arial", 12F);
            this.btn5.Location = new System.Drawing.Point(130, 155);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 40);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 6 Button
            this.btn6.Font = new System.Drawing.Font("Arial", 12F);
            this.btn6.Location = new System.Drawing.Point(190, 155);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 40);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Multiply Button
            this.btnMultiply.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMultiply.Location = new System.Drawing.Point(250, 155);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 40);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.BackColor = System.Drawing.Color.LightGoldenrodYellow; // Changed color

            // Number 1 Button
            this.btn1.Font = new System.Drawing.Font("Arial", 12F);
            this.btn1.Location = new System.Drawing.Point(70, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 40);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 2 Button
            this.btn2.Font = new System.Drawing.Font("Arial", 12F);
            this.btn2.Location = new System.Drawing.Point(130, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 40);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Number 3 Button
            this.btn3.Font = new System.Drawing.Font("Arial", 12F);
            this.btn3.Location = new System.Drawing.Point(190, 205);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 40);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Minus Button
            this.btnMinus.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMinus.Location = new System.Drawing.Point(250, 205);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(55, 40);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.BackColor = System.Drawing.Color.LightGoldenrodYellow; // Changed color

            // Number 0 Button
            this.btn0.Font = new System.Drawing.Font("Arial", 12F);
            this.btn0.Location = new System.Drawing.Point(70, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(115, 40);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Decimal Button
            this.btnDecimal.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDecimal.Location = new System.Drawing.Point(190, 255);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(55, 40);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.BackColor = System.Drawing.Color.LightSkyBlue; // Changed color

            // Plus Button
            this.btnPlus.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPlus.Location = new System.Drawing.Point(250, 255);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(55, 40);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.BackColor = System.Drawing.Color.LightGoldenrodYellow; // Changed color

            // Equals Button
            this.btnEquals.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEquals.Location = new System.Drawing.Point(190, 305);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(115, 40);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.BackColor = System.Drawing.Color.LightPink; // Changed color

            // Plus/Minus Button
            this.btnPlusMinus.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPlusMinus.Location = new System.Drawing.Point(70, 305);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(55, 40);
            this.btnPlusMinus.TabIndex = 21;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.BackColor = System.Drawing.Color.LightBlue; // Changed color

            // Reciprocal Button
            this.btnReciprocal.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReciprocal.Location = new System.Drawing.Point(130, 305);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(55, 40);
            this.btnReciprocal.TabIndex = 22;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.BackColor = System.Drawing.Color.LightYellow; // Changed color

            // M+ Button
            this.btnMPlus.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMPlus.Location = new System.Drawing.Point(10, 55);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(55, 40);
            this.btnMPlus.TabIndex = 23;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.BackColor = System.Drawing.Color.LightGreen; // Changed color

            // M- Button
            this.btnMMinus.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMMinus.Location = new System.Drawing.Point(10, 105);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(55, 40);
            this.btnMMinus.TabIndex = 24;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.BackColor = System.Drawing.Color.LightGreen; // Changed color

            // MR Button
            this.btnMR.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMR.Location = new System.Drawing.Point(10, 155);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(55, 40);
            this.btnMR.TabIndex = 25;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.BackColor = System.Drawing.Color.LightGreen; // Changed color

            // MC Button
            this.btnMC.Font = new System.Drawing.Font("Arial", 12F);
            this.btnMC.Location = new System.Drawing.Point(10, 205);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(55, 40);
            this.btnMC.TabIndex = 26;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.BackColor = System.Drawing.Color.LightGreen; // Changed color

            // Form1
            this.ClientSize = new System.Drawing.Size(320, 370);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
