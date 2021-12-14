using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Component
    public abstract class Laptop
    {
        public string Name;
        public double Cost;
        public string GetName()
        {
            return Name;
        }
        public double GetCost()
        {
            return Cost;
        }
    }
}
