using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.ISP
{
    public interface IBonus
    {
        decimal CalculateBonus(decimal amount);
    }
    public interface ITrade
    {
        float CalculateTradePrice(int count);
    }
    public class Employee4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string employeeType { get; set; }
        public Employee4(int id, string name, string employeeType)
        {
            this.id = id;
            this.name = name;
            this.employeeType = employeeType;
        }
    }
    public class Permenant : Employee4, IBonus, ITrade
    {
        public Permenant(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public decimal CalculateBonus(decimal amount)
        {
            return amount * 0.1M;
        }

        public float CalculateTradePrice(int count)
        {
            return count * 89.32f;
        }
    }
    public class Temporary : Employee4, ITrade, IBonus
    {
        public Temporary(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public decimal CalculateBonus(decimal amount)
        {
            return amount * 0.5M;
        }

        public float CalculateTradePrice(int count)
        {
            return count * 69.32f;
        }
    }
    public class Customer2 : Employee4, IBonus
    {
        public Customer2(int id, string name, string employeeType) : base(id, name, employeeType)
        {
        }
        public decimal CalculateBonus(decimal amount)
        {
            return amount * 0.8M;
        }
    }
}
