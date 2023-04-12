using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practical8.Customer;
using Practical8.Employee;

namespace Practical8
{
    internal class GetData
    {
        public static void MainOption()
        {
            Console.WriteLine("Enter your choice from: " +
                "\n 1 - Customer " +
                "\n 2 - Permanent Employee " +
                "\n 3 - Temporary Employee "
            );
        }
        public static void DisplayTransactionMessage()
        {
            Console.WriteLine("\n===========Transaction Completed===========");
        }
        public static void GetCustomer(Customers customers)
        {
            try
            {
                EnterDetail:
                Console.WriteLine("Enter Customer Name: ");
                customers.Name = Console.ReadLine();
                bool isNumeric = int.TryParse(customers.Name, out int value);
                if( isNumeric )
                {
                    Console.WriteLine("Error: Invalid name.");
                    goto EnterDetail;
                }
                Console.WriteLine("Enter your Account number: ");
                customers.AccountNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter your Bank Balance: ");
                customers.BankBalance = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Enter your choice from: " +
                    "\n 1 - Display the Name, Account Number & Bank Balance " +
                    "\n 2 - Deposit Amount " +
                    "\n 3 - WithDraw Amount " +
                    "\n 4 - Calculate iNTEREST of Loan Amount Borrowed"
                );
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void GetEmployee(Employees employees)
        {
            try
            {
                EnterDetail:
                Console.WriteLine("Enter Employee Name: ");
                employees.name = Console.ReadLine();
                bool isNumeric = int.TryParse(employees.name, out int value);
                if (isNumeric)
                {
                    Console.WriteLine("Error: Invalid name.");
                    goto EnterDetail;
                }
                Console.WriteLine("Enter your Salary: ");
                employees.salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your choice from: " +
                    "\n 1 - Display the Name, Salary & Employee Type " +
                    "\n 2 - Bonus Amount " +
                    "\n 3 - Trading Amount "
                );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
