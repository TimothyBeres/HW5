using HW5.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.GpuProducers
{
    //Concrete decorator
    public class AmdGpu : RamDecorator
    {
        public string DecoratorName = "AMD GPU";
        public double Price = 250;
        public AmdGpu(Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost += Price;
        }
    }
}
