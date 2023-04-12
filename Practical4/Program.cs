using System;
using System.Reflection.Metadata;

namespace Practical4
{
    public class Program
    {
        public static void Main(string[] args)
        {    
            DisplayOnScreen display = new DisplayOnScreen();
            Result result = new Result();
            Student student = new Student();
            try
            {
                EnterName:
                Console.WriteLine("Enter Student name : ");
                student.Name = Console.ReadLine();
                var isNumeric = int.TryParse(student.Name, out int n);
                if (isNumeric)
                {
                    Console.WriteLine("Error: Invalid Name!");
                    goto EnterName;
                }
                Console.WriteLine($"Enter Marks for {student.Name} : ");
                for (int i = 0; i < 5; i++)
                {
                    student.Marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                display.Options();
                result.Output(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}