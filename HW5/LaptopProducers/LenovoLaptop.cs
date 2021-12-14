using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Concrete component
    public class LenovoLaptop : Laptop 
    {
        public string ComponentName = "Lenovo Laptop";
        public double Price = 230;
        public LenovoLaptop()
        {
            Name = ComponentName;
            Cost = Price;
        }

    }
}
