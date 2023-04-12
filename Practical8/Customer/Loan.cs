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
                Enterdetail:
                Console.WriteLine("Enter Loan Amount: ");
                double Principal = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine("Enter Annual Rate of interest: ");
                double Rate = Convert.ToInt32(Console.ReadLine());
                Rate = Rate / 100;
                Console.WriteLine("Enter Total number of years: ");
                double year = Convert.ToInt32(Console.ReadLine());
                if (Principal < 0 || Rate < 0 || year < 0)
                {
                    Console.WriteLine("Error: Value cant be Negative");
                    goto Enterdetail;
                }
                double Interest = (Principal * Rate) / year;

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
