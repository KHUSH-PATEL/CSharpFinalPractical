using Practical3.Abstraction;
using Practical3.Inheritance;
using Practical3.Polymorphism;

namespace Practical3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Inheritance
            Team team = new Team(" CSK");
            string teamDetails = team.printInfo();
            Console.WriteLine(teamDetails);

            //Polymorphism
            Bird myBird = new Bird();
            Duck myDuck = new Duck();
            myBird.Voice();
            myDuck.Voice();

            //Abstraction
            Laptop laptop = new Laptop();
            laptop.Brand = "Lenovo";
            laptop.Model = "Legion Y540 i7, 9th gen, 256GB SSD, 1TB HDD";
            laptop.LaptopDetails();
            //laptop.MotherBoardInfo();
        }
    }
}