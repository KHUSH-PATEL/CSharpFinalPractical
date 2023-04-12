using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.SRP
{
    public class BankAccount
    {
        double p= 210000, r=7, t=12, si;
        public int AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public BankAccount()
        {
            this.AccountBalance = 10000;
            this.AccountNumber = 684565;
        }
        public decimal CalculateInterest()
        {
            si = p * r * t / 100;
            return (decimal)si;
        }
        public decimal CalculateLoan()
        {
            var loanAmount = 10000;
            var interest = 5.0;
            var numberOfYears = 5;

            // rate of interest and number of payments for monthly payments
            var rateOfInterest = interest / 1200;
            var numberOfPayments = numberOfYears * 12;

            var paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

            
            return (decimal)paymentAmount;
        }
    }
    public class Before_SRP : BankAccount
    {
        public static void BeforeSRP()
        {
            Before_SRP srp = new Before_SRP();
            
            Console.WriteLine("Total Interest is : " + srp.CalculateInterest());
            Console.WriteLine("Total Loan Amount is : " + srp.CalculateLoan());
        }
    }
}
