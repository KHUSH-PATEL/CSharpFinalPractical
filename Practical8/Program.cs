using Practical8.Customer;
using Practical8.Employee;

namespace Practical8
{
    class Program
    {
        public static void Main() 
        {
            Customers customers = new Customers();
            Employees employees = new Employees();
            GetData.MainOption();
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        GetData.GetCustomer(customers);
                        CustomerFeatures.CustomerFunctions(customers);
                        break;

                    case 2:
                        GetData.GetEmployee(employees);
                        PermenantFunction.PermenantEmployee(employees);
                        break;

                    case 3:
                        GetData.GetEmployee(employees);
                        TemporaryFunction.TemporaryEmployee(employees);
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