using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //Concrete decorator
    public class AmdProcessor : ProcessorDecorator
    {
        public string DecoratorName = "AMD processor";
        public double Price = 50;
        public AmdProcessor(Laptop laptop) : base(laptop)
        {
            Name +=  ", " + DecoratorName;
            Cost +=  Price;
        }
    }
}
