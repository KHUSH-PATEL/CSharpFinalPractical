using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class Result : Student
    {
        DisplayOnScreen display = new DisplayOnScreen();
        AvgMarks avgMarks = new AvgMarks();
        Grade grade = new Grade();
  
        public void Output(Student student)
        {
            string select = string.Empty;
            decimal avg = avgMarks.CalculateAverageMarks(student);

            do
            {
                Console.WriteLine("Choose your Option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (int)Student.Options.Aggregate:
                        Console.WriteLine($"Student name is {student.Name} and Average Marks is {avg}");
                        select = display.WantToContinue();
                        break;
                    case (int)Student.Options.MinMark:
                        Console.WriteLine($"Minimum Marks is {student.Marks.Min()}");
                        select = display.WantToContinue();
                        break;
                    case (int)Student.Options.MaximumMark:
                        Console.WriteLine($"Maximum Marks is {student.Marks.Max()}");
                        select = display.WantToContinue();
                        break;
                    case (int)Student.Options.Grade:
                        Console.WriteLine(grade.CalculateGrade((int)avg));
                        select = display.WantToContinue();
                        break;
                    default:
                        Console.WriteLine("Wrong option chosen");
                        select = display.WantToContinue();
                        break;
                }
            } while (select.ToLower() == "yes");
        }
    }
}
