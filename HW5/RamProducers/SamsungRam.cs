using HW5.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.RamProducers
{
    //Concrete decorator
    public class SamsungRam : RamDecorator
    {
        public string DecoratorName = "Samsung RAM";
        public double Price = 105;
        public SamsungRam(Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost += Price;
        }
    }
}
