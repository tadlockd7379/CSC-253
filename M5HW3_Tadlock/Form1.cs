
/**
* 11/27/2023
* CSC 253
* Drew Tadlock
* Search a database file
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M5HW3_Tadlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var dataTable = productDBDataSet.Product;

            var query = from row in dataTable.AsEnumerable()
                        where
                            (row.Field<string>("Product_Number").Contains(numberInput.Text) || string.IsNullOrEmpty(numberInput.Text)) &&
                            (row.Field<string>("Description").Contains(descriptionInput.Text) || string.IsNullOrEmpty(descriptionInput.Text))
                        select row;

            try
            {
                DataTable filteredDataTable = query.CopyToDataTable();

                data.DataSource = filteredDataTable;
            } catch
            {
                MessageBox.Show("Unable to find result.");
            }
        }
    }
}
