using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositeLibrary
{
    public partial class GroupedControl : UserControl
    {
        public GroupedControl()
        {
            InitializeComponent();
        }

        private void GroupedControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Input: {TextBox.Text}");
        }

    }     
}