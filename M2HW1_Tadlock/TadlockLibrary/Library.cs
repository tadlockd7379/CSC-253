using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadlockLibrary
{
    public enum Shift
    {
        DAY = 1,
        NIGHT = 2
    }

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

    public class ProductionWorker : Employee
    {
        public Shift shift;
        public double wage;
        public ProductionWorker(string name, int number, Shift shift, double wage) : base(name, number)
        {
            this.shift = shift;
            this.wage = wage;
        }
    }
}
