using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3HW1_LastName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personnelDataSet.Table);

        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            DataView dv = personnelDataSet.Table.DefaultView;
            dv.RowFilter = "name LIKE '" + searchInput.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void highestPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personnelDataSet.Table.Compute("max([salary])", string.Empty).ToString());
        }

        private void lowestPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personnelDataSet.Table.Compute("min([salary])", string.Empty).ToString());
        }
    }
}
