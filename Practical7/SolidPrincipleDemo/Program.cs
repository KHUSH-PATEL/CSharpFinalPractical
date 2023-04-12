using SolidPrincipleDemo.DIP;
using SolidPrincipleDemo.ISP;
using SolidPrincipleDemo.LSP;
using SolidPrincipleDemo.OCP;
using SolidPrincipleDemo.SRP;

namespace SolidPrincipleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice of Solid Principle");
            Console.WriteLine("------------Menu------------");
            Console.WriteLine("\n 1: SRP \n 2: OCP \n 3: ISP \n 4: LSP \n 5: DIP");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Before_SRP.BeforeSRP();
                    After_SRP.AfterSRP();
                    break;
                case 2:
                    Employee employee = new Employee(1, "khush", "Permanent");
                    Employee employee2 = new Employee(2, "Om", "Permanent");
                    Employee2 employee3 = new PermanentEmployee(1, "Khush");
                    Employee2 employee4 = new TemporaryEmployee(2, "Om");
                    Console.WriteLine($"Employee name: {employee3.Name} and Bonus: {employee3.CalculateBonus(100000)}");
                    Console.WriteLine($"Employee name: {employee4.Name} and Bonus: {employee4.CalculateBonus(15000)}");
                    break;
                case 3:
                    Employee3 emp = new PermenantEmployee(1, "Khush", "Permenant");
                    Employee3 emp2 = new TempEmployee(2, "Om", "Temporary");
                    Employee3 emp3 = new Customer(3, "Arpan", "Customer");
                    Console.WriteLine($"Employee name: {emp.name}, Type: {emp.employeeType}, Bonus: {emp.CalculateBonus(100000)} and Trading Price: {emp.CalculateTradePrice(60)}");
                    Console.WriteLine($"Employee name: {emp2.name}, Type: {emp2.employeeType}, Bonus: {emp2.CalculateBonus(100000)} and Trading Price: {emp2.CalculateTradePrice(60)}");
                    Console.WriteLine($"Employee name: {emp3.name}, Type: {emp3.employeeType}, Bonus: {emp3.CalculateBonus(100000)} and Trading Price: {emp3.CalculateTradePrice(60)}");

                    Permenant emp4 = new Permenant(1, "Khush", "Permenant");
                    Temporary emp5 = new Temporary(2, "Om", "Temporary");
                    Customer2 emp6 = new Customer2(3, "Arpan", "Customer");
                    Console.WriteLine($"Employee name: {emp4.name}, Type: {emp4.employeeType}, Bonus: {emp4.CalculateBonus(100000)} and Trading Price: {emp4.CalculateTradePrice(60)}");
                    Console.WriteLine($"Employee name: {emp5.name}, Type: {emp5.employeeType}, Bonus: {emp5.CalculateBonus(100000)} and Trading Price: {emp5.CalculateTradePrice(60)}");
                    Console.WriteLine($"Employee name: {emp6.name}, Type: {emp3.employeeType}, Bonus: {emp6.CalculateBonus(100000)}");
                    break;
                case 4:
                    Father2 x = new Father2();
                    //Son2 x2 = new Father2();
                    Console.WriteLine($"Father's Occupation: {x.GetOccupation()}");
                    //Console.WriteLine($"Son's Occupation: {x2.GetOccupation()}");

                    Console.WriteLine("Occupation ");
                    IOccupation occupation = new Father();
                    Console.WriteLine("Father's Occupation : " + occupation.GetOccupation());
                    occupation = new Son();
                    Console.WriteLine("Son's Occupation : " + occupation.GetOccupation());
                    break;
                case 5:
                    Employee6 emp7 = new Employee6();
                    Console.WriteLine($"Before DIP: Salary of employee is {emp7.Salary(8, 30)}");
                    EmployeeDetailsModified employeeDetailsModified = new EmployeeDetailsModified(new SalaryCalculatorModified());
                    employeeDetailsModified.HourlyRate = 50;
                    employeeDetailsModified.HoursWorked = 150;
                    Console.WriteLine($"After DIP: Salary of employee is {employeeDetailsModified.GetSalary()}");
                    break;
            }
            Console.ReadLine();
        }
    }
}