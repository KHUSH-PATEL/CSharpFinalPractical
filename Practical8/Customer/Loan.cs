using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    public interface ILoanAmount
    {
        double CalculateLoan();
    }
    internal sealed class Loan : ILoanAmount
    {
        public double CalculateLoan()
        {
            try
            {
                Console.WriteLine("Enter Loan Amount: ");
                double P = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Annual Rate of interest: ");
                double R = Convert.ToInt32(Console.ReadLine());
                R = R / 100;
                Console.WriteLine("Enter Total number of years: ");
                double N = Convert.ToInt32(Console.ReadLine());
                double Interest = (P * R) / N;

                return Interest;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
    }
}
