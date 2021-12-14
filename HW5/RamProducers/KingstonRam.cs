using HW5.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.RamProducers
{
    //Concrete decorator
    public class KingstonRam : RamDecorator
    {
        public string DecoratorName = "Kingston RAM";
        public double Price = 75;
        public KingstonRam(Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost += Price;
        }
    }
}
