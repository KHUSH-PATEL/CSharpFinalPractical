using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.SRP
{ 
    public class BankAccount2
    { 
        public int AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public BankAccount2()
        {
            this.AccountBalance = 10000;
            this.AccountNumber = 684565;
        }
    }
    public class Interest
    {
        double p=342542, r=12, t=6, si;
        public decimal CalculateInterest()
        {
            si = p * r * t / 100;
            return (decimal)si;
        }
    }
    public class Loan
    {
        public decimal CalculateLoan()
        {
            var loanAmount = 8564;
            var interest = 5.0;
            var numberOfYears = 6;
            var rateOfInterest = interest / 1200;
            var numberOfPayments = numberOfYears * 12;

            var paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));
            return (decimal)paymentAmount;
        }
    }
    public class After_SRP
    {
        public static void AfterSRP()
        {
            After_SRP srp2 = new After_SRP();
            Interest i = new Interest();
            Loan loan = new Loan();
            Console.WriteLine("Total Interest is : " + i.CalculateInterest());
            Console.WriteLine("Total Loan Amount is : " + loan.CalculateLoan());
        }
    }
}
