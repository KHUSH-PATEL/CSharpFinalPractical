using Practical8.Customer;
using Practical8.Employee;

namespace Practical8
{
    class Program
    {
        public static void Main()
        {

            GetData.MainOption();
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        GetData.GetCustomer();
                        CustomerFunction.Functions();
                        break;

                    case 2:
                        GetData.GetEmployee();
                        PermenantFunction.Permenant();
                        break;

                    case 3:
                        GetData.GetEmployee();
                        TemporaryFunction.Temporary();
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice.");
                        Main();
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}