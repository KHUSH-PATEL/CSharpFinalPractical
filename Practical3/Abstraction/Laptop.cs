using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Abstraction
{
    internal class Laptop
    {
        private string _brand;
        private string _model;
        public string Brand 
        { 
            get { return _brand; } 
            set { _brand = value; } 
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// LaptopDetails() prints Brand and model. 
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        /// <summary>
        /// MotherBoardInfo() prints MotherBoard Information but its private so cant be accessible.
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
