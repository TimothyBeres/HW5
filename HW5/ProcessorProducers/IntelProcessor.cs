using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Concrete decorator
    public class IntelProcessor : ProcessorDecorator
    {
        public string DecoratorName = "Intel processor";
        public double Price = 70;
        public IntelProcessor(Laptop laptop) : base(laptop)
        {
            Name += ", " + DecoratorName;
            Cost +=  Price;
        }
        
    }
}
