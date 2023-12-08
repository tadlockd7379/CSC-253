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
            string shift = shiftInput.Text;
            string wage = wageInput.Text;

            int numberFinal;
            Shift? shiftFinal = null;
            double wageFinal;

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

            switch (shift.ToLower())
            {
                case "day":
                    shiftFinal = Shift.DAY;
                    break;
                case "night":
                    shiftFinal = Shift.NIGHT;
                    break;
            }

            if (shiftFinal == null)
            {
                try
                {
                    int shiftNumber = int.Parse(shift);

                    switch (shiftNumber)
                    {
                        case 1:
                            shiftFinal = Shift.DAY;
                            break;
                        case 2:
                            shiftFinal = Shift.NIGHT;
                            break;
                        default:
                            MessageBox.Show("Invalid Shift. Give '1', '2', 'Day', or 'Night'.");
                            return;
                    }
                    numberFinal = int.Parse(number);
                }
                catch
                {
                    MessageBox.Show("Invalid Shift. Give '1', '2', 'Day', or 'Night'.");
                    return;
                }
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

            ProductionWorker employee = new ProductionWorker(name, numberFinal, shiftFinal.Value, wageFinal);
            MessageBox.Show($"{employee.name} (Employee no. {employee.name}) works the {employee.shift} shift and makes ${employee.wage} an hour.");
        }
    }
}
