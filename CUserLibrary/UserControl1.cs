using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLibrary
{
    public partial class DataGridControl: UserControl
    {
        public DataGridControl()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Rows.Add(1, "Tasnim");
            table.Rows.Add(2, "Muntaha");
            table.Rows.Add(3, "Abubakar");
            table.Rows.Add(4, "Ahmad Ejaz");
            table.Rows.Add(5, "Ali Haider");

            dataGridView.DataSource = table;
        }


        private void DataGridControl_Load(object sender, EventArgs e)
        {

        }
    }
}
