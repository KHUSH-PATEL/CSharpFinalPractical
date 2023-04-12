using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.LSP
{
    interface IOccupation
    {
        String GetOccupation();
    }
    class Father : IOccupation
    {
        public string GetOccupation()
        {
            return "Business Man";
        }
    }
    class Son : IOccupation
    {
        public String GetOccupation()
        {
            return "Corporate ";
        }
    }
}
