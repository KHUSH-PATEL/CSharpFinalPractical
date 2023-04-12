using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                DisplayData(num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// This method prints the sum, subtraction, multiplication and division.
        /// checks the user has not taken any wrong input.
        /// </summary>
        private static void DisplayData(int x, int y)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, x + y);
            Console.WriteLine("The subtraction of {0} and {1} is {2}", x, y, x - y);
            Console.WriteLine("The multiplication of {0} and {1} is {2}", x, y, x * y);
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                Console.WriteLine("The division of {0} and {1} is {2}", x, y, x / y);
            }
        }
    }
}