using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Polymorphism
{
    internal class Duck : Bird
    {
        /// <summary>
        /// This method will override Bird.Voice()
        /// </summary>
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
