using Practical4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        public decimal AverageMarks;
        public enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
    }
}