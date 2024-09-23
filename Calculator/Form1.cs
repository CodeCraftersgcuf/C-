using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double _currentValue = 0;
        private string _operation = "";
        private bool _isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Number Button Click
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (_isOperationPressed)
            {
                txtResult.Clear();
                _isOperationPressed = false;
            }

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        // Operation (+, -) Button Click
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (_currentValue != 0)
            {
                btnEquals.PerformClick();
                _operation = btn.Text;
                _isOperationPressed = true;
            }
            else
            {
                _operation = btn.Text;
                _currentValue = double.Parse(txtResult.Text);
                _isOperationPressed = true;
            }
        }

        // Equals Button Click
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(txtResult.Text);

            switch (_operation)
            {
                case "+":
                    txtResult.Text = (_currentValue + secondValue).ToString();
                    break;
                case "-":
                    txtResult.Text = (_currentValue - secondValue).ToString();
                    break;
            }

            _currentValue = 0;
            _operation = "";
        }

        // Clear Button Click
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            _currentValue = 0;
            _operation = "";
        }
    }
}
