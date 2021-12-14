using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Abstracts
{
    //Decorator
    public abstract class GpuDecorator : Laptop
    {
        public GpuDecorator(Laptop laptop)
        {
            Name = laptop.Name;
            Cost = laptop.Cost;
        }
    }
}
