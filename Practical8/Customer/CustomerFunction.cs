using Practical8.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    internal class CustomerFunction : GetData
    {
        public static void Functions()
        {
            Withdraw withdraw = new Withdraw();
            Deposit deposit = new Deposit();
            Loan loan = new Loan();
            Bonus bonus = new Bonus();

            Console.WriteLine("Choose your Option");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Name: {Customers.Name}, Account Number: {Customers.AccountNumber} & Bank Balance: {Customers.BankBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Choose Amount to deposit");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        GetData.displayMessage();
                        Console.WriteLine($"New available Balance is: {deposit.DepositAmount(Customers.BankBalance, temp)}");
                        break;
                    case 3:
                        Console.WriteLine("Choose Amount to withdraw");
                        int x = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (Customers.BankBalance > x)
                            {
                                GetData.displayMessage();
                                Console.WriteLine($"New available Balance is: {withdraw.WithdrawAmount(Customers.BankBalance, x)}");
                            }
                            else
                            {
                                throw new Exception("Transaction In-completed. Not enough bank balance!");
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
