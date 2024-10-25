using System;
using System.Windows;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Add Button Click
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the numbers from the textboxes
                int firstNumber = int.Parse(txtFirstNumber.Text);
                int secondNumber = int.Parse(txtSecondNumber.Text);

                // Perform addition
                int result = firstNumber + secondNumber;

                // Display result
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid integers.");
            }
        }

        // Multiply Button Click
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the numbers from the textboxes
                int firstNumber = int.Parse(txtFirstNumber.Text);
                int secondNumber = int.Parse(txtSecondNumber.Text);

                // Perform multiplication
                int result = firstNumber * secondNumber;

                // Display result
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid integers.");
            }
        }

        // Clear Button Click
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear the input and result textboxes
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            txtResult.Text = "";
        }
    }
}
