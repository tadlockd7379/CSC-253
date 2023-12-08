/**
* 9/24
* CSC 253
* Drew Tadlock
* Employee and ProductionWorker Class
*/

using System;
using System.Windows.Forms;
using TadlockLibrary;

namespace M2HW1_Tadlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string number = numberInput.Text;
            string wage = wageInput.Text;
            string bonus = bonusInput.Text;
            string requiredHours = requiredHoursInput.Text;
            string currentHours = currentHoursInput.Text;

            int numberFinal;
            double wageFinal;
            double bonusFinal;
            double requiredHoursFinal;
            double attendedHoursFinal;

            if (name.Length < 1)
            {
                MessageBox.Show("Invalid Employee name.");
                return;
            }

            try
            {
                numberFinal = int.Parse(number);
            } catch
            {
                MessageBox.Show("Invalid Employee ID number.");
                return;
            }

            try
            {
                wageFinal = double.Parse(wage);
            }
            catch
            {
                MessageBox.Show("Invalid wage.");
                return;
            }

            try
            {
                bonusFinal = double.Parse(bonus);
            }
            catch
            {
                MessageBox.Show("Invalid bonus.");
                return;
            }

            try
            {
                requiredHoursFinal = double.Parse(requiredHours);
            }
            catch
            {
                MessageBox.Show("Invalid required hours.");
                return;
            }

            try
            {
                attendedHoursFinal = double.Parse(currentHours);
            }
            catch
            {
                MessageBox.Show("Invalid current hours.");
                return;
            }

            TeamLeader employee = new TeamLeader(name, numberFinal, bonusFinal, wageFinal, requiredHoursFinal, attendedHoursFinal);
            MessageBox.Show($"{employee.name} (Employee no. {employee.name}) makes ${employee.wage} an hour, and gets a ${employee.monthlyBonus} bonus for attending ${requiredHours} hours. They current havle ${attendedHoursFinal} hours attended.");
        }
    }
}
