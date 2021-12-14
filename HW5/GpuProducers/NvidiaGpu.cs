using HW5.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.GpuProducers
{
    //Concrete decorator
    public class NvidiaGpu : GpuDecorator
    {
        public string DecoratorName = "Nvidia GPU";
        public double Price = 350;
        public NvidiaGpu(Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost += Price;
        }
    }
}
