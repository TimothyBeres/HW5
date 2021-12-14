using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Decorator
    public abstract class ProcessorDecorator : Laptop
    {
        public ProcessorDecorator(Laptop laptop)
        {
            Name = laptop.Name;
            Cost = laptop.Cost;
        }
    }
}
