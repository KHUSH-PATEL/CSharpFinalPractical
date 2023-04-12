using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    internal sealed class Withdraw : Customers
    {
        public long WithdrawAmount(long balance, int amount)
        {
            return balance - amount;
        }
    }
}
