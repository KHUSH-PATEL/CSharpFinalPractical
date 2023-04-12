using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Employee
{
    internal class TemporaryFunction
    {
        public static void Temporary()
        {
            TemporaryEmployee temporaryEmployee = new TemporaryEmployee();
            Trade trade = new Trade();
            Console.WriteLine("Choose your Option");
            int select2 = Convert.ToInt32(Console.ReadLine());
            switch (select2)
            {
                case 1:
                    Console.WriteLine($"Employee Name: {Employees.name}, Salary: {Employees.salary} & Employee Type: Temporary Employee");
                    break;
                case 2:
                    Console.WriteLine(temporaryEmployee.CalculateBonus(Employees.salary));
                    break;
                case 3:
                    Console.WriteLine("Enter no of trade shares:");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(trade.CalculateTrade("Temporary"));
                    break;
            }
        }
    }
}
