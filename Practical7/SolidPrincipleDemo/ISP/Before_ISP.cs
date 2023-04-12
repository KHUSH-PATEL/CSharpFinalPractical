using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.ISP
{
    public class Employee3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string employeeType { get; set; }
        public Employee3(int Id, string name, string employeeType)
        {
            this.id = id;
            this.name = name;
            this.employeeType = employeeType;
        }
        public decimal CalculateBonus(decimal amount)
        {
            if (this.employeeType == "Permenant")
            {
                return amount * 0.1M;
            }
            else
            {
                return amount * 0.5M;
            }
        }
        public virtual float CalculateTradePrice(int count)
        {
            //base price. price fluctuate on Permenant employee, Temporary employee and customer.
            return count * 59.32f;
        }
    }
    public class PermenantEmployee : Employee3
    {
        public PermenantEmployee(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public override float CalculateTradePrice(int count)
        {
            //base price. price fluctuate on employee and customer.
            return count * 89.32f;
        }
    }
    public class TempEmployee : Employee3
    {
        public TempEmployee(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public override float CalculateTradePrice(int count)
        {
            return count * 69.32f;
        }

    }

    public class Customer : Employee3
    {
        public Customer(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public override float CalculateTradePrice(int count)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }

    }
}
