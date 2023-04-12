using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class DisplayOnScreen
    {
        public void Options()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("Enter your choice from: " +
                "\n 1 - Aggregate: Display the Name & Average marks of the student " +
                "\n 2 - MinMark: Display the minimum marks of the student " +
                "\n 3 - MaxMark: Display the maximum marks of the student " +
                "\n 4 - Grade: Display final grade based on Average marks of the student"
            );
        }
        public string WantToContinue()
        {
            string choose = string.Empty;
            Console.WriteLine("Want to continue ? Yes or No");
            choose = Console.ReadLine();
            return choose;
        }
    }
}
