using Practical8.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    internal class CustomerFeatures : GetData
    {
        public static void CustomerFunctions(Customers customers)
        {
            Withdraw withdraw = new Withdraw();
            Deposit deposit = new Deposit();
            Loan loan = new Loan();

            Console.WriteLine("Choose your Option");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Name: {customers.Name}, Account Number: {customers.AccountNumber} & Bank Balance: {customers.BankBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Choose Amount to deposit");
                        decimal temp = Convert.ToDecimal(Console.ReadLine());
                        GetData.DisplayTransactionMessage();
                        Console.WriteLine($"New available Balance is: {deposit.DepositAmount(customers.BankBalance, temp)}");
                        break;
                    case 3:
                        Console.WriteLine("Choose Amount to withdraw");
                        decimal x = Convert.ToDecimal(Console.ReadLine());
                        try
                        {
                            if (customers.BankBalance > x)
                            {
                                GetData.DisplayTransactionMessage();
                                Console.WriteLine($"New available Balance is: {withdraw.WithdrawAmount(customers.BankBalance, x)}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Transaction In-completed. Not enough bank balance!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        Console.WriteLine($"Interest is: {loan.CalculateLoan()}");
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice.");
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
