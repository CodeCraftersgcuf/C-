using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLibrary
{
    public partial class CustomButton: UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public string ButtonText
        {
            get { return button.Text; }
            set { button.Text = value; }
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"'{button.Text}'  Clicked Successfully!");
        }

        private void CustomButton_Load(object sender, EventArgs e)
        {

        }
    }
}
