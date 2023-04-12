using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class AvgMarks : Student
    {
        public decimal CalculateAverageMarks(Student student)
        {
            for (int i = 0; i < student.Marks.Length; i++)
            {
                student.AverageMarks += student.Marks[i];
            }
            return student.AverageMarks / 5;
        }
    }
}
