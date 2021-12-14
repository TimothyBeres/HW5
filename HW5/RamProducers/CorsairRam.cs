using HW5.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.RamProducers
{
    //Concrete decorator
    public class CorsairRam : RamDecorator
    {
        public string DecoratorName = "Corsair RAM";
        public double Price = 85;
        public CorsairRam (Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost += Price;
        }
    }
}
