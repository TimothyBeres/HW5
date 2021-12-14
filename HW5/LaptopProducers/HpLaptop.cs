using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Concrete component
    public class HpLaptop : Laptop 
    {
        public string ComponentName = "HP Laptop";
        public double Price = 250;
        public HpLaptop()
        {
            Name = ComponentName;
            Cost = Price;
        }

    }
}
