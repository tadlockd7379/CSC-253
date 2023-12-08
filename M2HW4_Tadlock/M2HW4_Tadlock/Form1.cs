/**
* 10/1/2023
* CSC 253
* Drew Tadlock
* Demonstrate various String extension utilities
*/

using System;
using System.Windows.Forms;
using TadlockLibrary;

namespace M2HW4_Tadlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toCharArrayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", toCharArrayInput.Text.ToCharArray()));
        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", dateInput.Text.DateToArray()));
        }

        private void phoneNumberButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneNumberInput.Text.PhoneNumber());
        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(backwardsInput.Text.Backwards());
        }

        private void numberOfWordsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + numberOfWordsInput.Text.WordCount() + " words.");
        }
    }
}
