/**
* 9/24
* CSC 253
* Drew Tadlock
* Employee and ProductionWorker Class
*/

using System;
using System.Windows.Forms;

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
            string salary = salaryInput.Text;
            string bonus = bonusInput.Text;

            int numberFinal;
            double salaryFinal;
            double bonusFinal;

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
                salaryFinal = double.Parse(salary);
            }
            catch
            {
                MessageBox.Show("Invalid salary.");
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

            ShiftSupervisor employee = new ShiftSupervisor(name, numberFinal, salaryFinal, bonusFinal);
            MessageBox.Show($"{employee.name} (Employee no. {employee.number}) makes ${employee.salary} a year and gets a ${bonusFinal} bonus.");
        }
    }

    class Employee
    {
        public string name;
        public int number;
        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    class ShiftSupervisor : Employee
    {
        public double salary;
        public double bonus;
        public ShiftSupervisor(string name, int number, double salary, double bonus) : base(name, number) 
        {
            this.salary = salary;
            this.bonus = bonus;
        }
    }
}
