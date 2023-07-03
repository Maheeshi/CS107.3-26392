using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_KMtoM
{
    internal class ConvertValues
    {
        public void KilometerTOmeter(double km)
        {
            //No return type with parameter method
            double m = 1000 * km;
            Console.WriteLine($"{km} kilometers is equal to {m} meters");
            Console.ReadKey();
        }
    }

       
}
