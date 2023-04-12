using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.OCP
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string EmployeeType { get; set; } //employee type defined later for different bonus.

        public Employee(int id, string Name, string Employeetype)
        {
            this.Id = id;
            this.Name = Name;
            this.EmployeeType = Employeetype;
        }
        public decimal CalculateBonus(decimal amount)
        {
            if(EmployeeType == "Permanent")
            {
                return amount * 0.1M;
            }
            if (EmployeeType == "Temporary")
            {
                return amount * 0.3M;
            }
            return amount * 0.5M;
        }
    }
}
