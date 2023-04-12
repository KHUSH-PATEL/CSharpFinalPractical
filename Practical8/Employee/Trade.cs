using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8.Employee
{
    internal class Trade
    {
        //By default everyone has 10 shares.
        public double CalculateTrade(string type)
        {
            if (type.ToLower() == "permanent")
            {
                return 10 * 95.90;
            }
            else
            {
                return 10 * 65.67;
            }
        }
        public double CalculateTrade(int count, string type)
        {
            if (type.ToLower() == "permanent")
            {
                return count * 95.90;
            }
            else
            {
                return count * 65.67;
            }
        }
    }
}
