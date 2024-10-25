using CompositeLibrary;
using CustomLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace UserControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeControls();

        }

        private void InitializeControls()
        {
            // Create and add GroupedControl (Composite User Control)
            var groupedControl = new GroupedControl
            {
            Location = new System.Drawing.Point(10, 10) // Position the control on the form
            };
            Controls.Add(groupedControl);




            // Create and add CustomButton (Custom User Control)
            var customButton = new CustomButton
            {
            Location = new System.Drawing.Point(10, 160) // Position the control on the form
            };
            customButton.ButtonText = "Click Me"; // Set the button text
            Controls.Add(customButton);




            // Create and add DataGridControl (Data-bound User Control)
            var dataGridControl = new DataGridControl
            {
            Location = new System.Drawing.Point(10, 210) // Position the control on the form
            };
            Controls.Add(dataGridControl);
        }

             private void Form1_Load(object sender, EventArgs e)
             {

             }

        private void dataGridControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
