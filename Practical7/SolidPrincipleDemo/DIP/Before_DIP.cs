using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.DIP
{
    public class SalaryCalculate
    {
        public float Getsalary(int hours, int hourlyRate) 
        {
            return hourlyRate * hours;
        }     
    }
    public class Employee6
    {
        public int hours
        {
            get;
            set;
        }
        public int hourlyRate
        {
            get;
            set;
        }
        public float Salary(int hours, int hourlyRate)
        {
            SalaryCalculate sc = new SalaryCalculate();
            return sc.Getsalary(hours, hourlyRate);
        }
    }
}
