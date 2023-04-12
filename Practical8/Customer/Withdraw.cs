using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    internal sealed class Withdraw : Customers
    {
        public decimal WithdrawAmount(decimal balance, decimal amount)
        {
            return balance - amount;
        }
    }
}
