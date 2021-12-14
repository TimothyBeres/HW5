using HW5.GpuProducers;
using HW5.RamProducers;
using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop dellLaptop = new DellLaptop();
            dellLaptop = new AmdProcessor(dellLaptop);
            dellLaptop = new CorsairRam(dellLaptop);
            dellLaptop = new AmdGpu(dellLaptop);
            Console.WriteLine(dellLaptop.GetName());
            Console.WriteLine(dellLaptop.GetCost());

            Console.ReadLine();
        }
    }
}
