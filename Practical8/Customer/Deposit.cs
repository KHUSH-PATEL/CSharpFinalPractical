using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Customer
{
    internal sealed class Deposit : Customers
    {
        public long DepositAmount(long balance, int amount)
        {
            return balance + amount;
        }
    }
}
