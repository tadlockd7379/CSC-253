using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadlockLibrary
{
    public class Employee
    {
        public string name;
        public int number;
        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    public class TeamLeader : Employee
    {
        public double wage;
        public double monthlyBonus;
        public double requiredHours;
        public double attendedHours;

        public TeamLeader(string name, int number, double monthlyBonus, double wage, double requiredHours, double attendedHours) : base(name, number)
        {
            this.monthlyBonus = monthlyBonus;
            this.wage = wage;

            this.requiredHours = requiredHours;
            this.attendedHours = attendedHours;
        }
    }
}
