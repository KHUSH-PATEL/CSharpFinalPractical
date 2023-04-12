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
  
        public void Output()
        {
            string select = string.Empty;
            decimal avg = avgMarks.CalculateAverageMarks();

            do
            {
                Console.WriteLine("Choose your Option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (int)Student.Options.Aggregate:
                        Console.WriteLine($"Student name is {Student.Name} and Average Marks is {avg}");
                        select = display.Continue();
                        break;
                    case (int)Student.Options.MinMark:
                        Console.WriteLine($"Minimum Marks is {Student.Marks.Min()}");
                        select = display.Continue();
                        break;
                    case (int)Student.Options.MaximumMark:
                        Console.WriteLine($"Maximum Marks is {Student.Marks.Max()}");
                        select = display.Continue();
                        break;
                    case (int)Student.Options.Grade:
                        Console.WriteLine(grade.CalculateGrade((int)avg));
                        select = display.Continue();
                        break;
                    default:
                        Console.WriteLine("Wrong option chosen");
                        select = display.Continue();
                        break;
                }
            } while (select.ToLower() == "yes");
        }
    }
}
