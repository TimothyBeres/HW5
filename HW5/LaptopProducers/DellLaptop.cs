using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Concrete component
    public class DellLaptop : Laptop
    {
        public string ComponentName = "Dell Laptop";
        public double Price = 300;
        public DellLaptop()
        {
            Name = ComponentName;
            Cost = Price;
        }
    }
}
