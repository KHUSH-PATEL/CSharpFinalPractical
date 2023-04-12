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
           
            try
            {
                Console.WriteLine("Enter Student name : ");
                Student.Name = Console.ReadLine();
                var isNumeric = int.TryParse(Student.Name, out int n);
                if (isNumeric)
                {
                    throw new Exception("Invalid Name!");
                }
                Console.WriteLine($"Enter Marks for {Student.Name} : ");
                for (int i = 0; i < 5; i++)
                {
                    Student.Marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                display.Options();
                result.Output();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}