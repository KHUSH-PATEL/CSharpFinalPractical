using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Employee
{
    internal class PermenantFunction
    {
        public static void Permenant()
        {
            PermenantEmployee permenantEmployee = new PermenantEmployee();
            Trade trade = new Trade();

            Console.WriteLine("Choose your Option");
            int chose = Convert.ToInt32(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    Console.WriteLine($"Employee Name: {Employees.name}, Salary: {Employees.salary} & Employee Type: Permanent Employee");
                    break;
                case 2:
                    Console.WriteLine(permenantEmployee.CalculateBonus(Employees.salary));
                    break;
                case 3:
                    Console.WriteLine("Enter no of trade shares:");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(trade.CalculateTrade(35, "Permanent"));
                    break;
                default:
                    Console.WriteLine("Please enter correct choice.");
                    break;
            }
        }
    }
}
