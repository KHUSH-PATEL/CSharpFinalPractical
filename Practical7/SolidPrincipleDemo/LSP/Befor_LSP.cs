using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.LSP
{
    class Father2
    {
        public virtual string GetOccupation()
        {
            return "Business Man";
        }
    }
    class Son2 : Father2
    {
        public override string GetOccupation()
        {
            return "Corporate";
        }
    }
}
