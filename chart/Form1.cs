using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the values from NumericUpDown controls
            int engineeringStaff = (int)Engin.Value;
            int lawStaff = (int)law.Value;
            int adminStaff = (int)AS.Value;
            int artsStaff = (int)Arts.Value;

            // Update Column Chart (chart1)
            chart1.Series["No of Staff"].Points.Clear();
            chart1.Series["No of Staff"].Points.AddXY("Engineering", engineeringStaff);
            chart1.Series["No of Staff"].Points.AddXY("Law", lawStaff);
            chart1.Series["No of Staff"].Points.AddXY("Administrative Sciences", adminStaff);
            chart1.Series["No of Staff"].Points.AddXY("Arts & Science", artsStaff);

            // Update Bar Chart (chart2)
            chart2.Series["No of Staff"].Points.Clear();
            chart2.Series["No of Staff"].Points.AddXY("Engineering", engineeringStaff);
            chart2.Series["No of Staff"].Points.AddXY("Law", lawStaff);
            chart2.Series["No of Staff"].Points.AddXY("Administrative Sciences", adminStaff);
            chart2.Series["No of Staff"].Points.AddXY("Arts & Science", artsStaff);

            // Update Pie Chart (chart3)
            chart3.Series["No of staff"].Points.Clear();
            chart3.Series["No of staff"].Points.AddXY("Engineering", engineeringStaff);
            chart3.Series["No of staff"].Points.AddXY("Law", lawStaff);
            chart3.Series["No of staff"].Points.AddXY("Administrative Sciences", adminStaff);
            chart3.Series["No of staff"].Points.AddXY("Arts & Science", artsStaff);


            // Update Line Chart (chart4)
            chart4.Series["No of Staff"].Points.Clear();
            chart4.Series["No of Staff"].Points.AddXY("Engineering", engineeringStaff);
            chart4.Series["No of Staff"].Points.AddXY("Law", lawStaff);
            chart4.Series["No of Staff"].Points.AddXY("Administrative Sciences", adminStaff);
            chart4.Series["No of Staff"].Points.AddXY("Arts & Science", artsStaff);
        
    }
           //created beacuse of double click (by mistaken)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
