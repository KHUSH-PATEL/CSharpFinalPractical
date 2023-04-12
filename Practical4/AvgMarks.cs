using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class AvgMarks : Student
    {
        public decimal CalculateAverageMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                AverageMarks += Marks[i];
            }
            return AverageMarks / 5;
        }
    }
}
