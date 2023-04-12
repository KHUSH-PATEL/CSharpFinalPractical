using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.OCP
{

    public abstract class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee2(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }
        public abstract decimal CalculateBonus(decimal amount2);
    }
    public class PermanentEmployee : Employee2
    {
        public PermanentEmployee(int id, string Name) : base(id, Name) 
        {
        }
        public override decimal CalculateBonus(decimal amount2)
        {
            return amount2 * 0.1M;
        }
    }
    public class TemporaryEmployee : Employee2
    {
        public TemporaryEmployee(int id, string Name) : base(id, Name)
        {
        }
        public override decimal CalculateBonus(decimal amount2)
        {
            return amount2 * 0.5M;
        }
    }
}
