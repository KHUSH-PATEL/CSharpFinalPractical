using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public class Student
    {
        public static string Name;
        public static decimal[] Marks = new decimal[5];
        public static decimal AverageMarks;
        public enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
    }
}
