using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class Grade : Student
    {
        public string CalculateGrade(int marks)
        {
            marks = marks / 10;
            switch (marks)
            {
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                default:
                    return "D";
            }
        }
    }
}
