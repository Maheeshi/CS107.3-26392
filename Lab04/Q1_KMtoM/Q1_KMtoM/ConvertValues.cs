using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_KMtoM
{
    internal class ConvertValues
    {
        public void KilometerTOmeter()
        {   //No return type No Parameter Method
            Console.Write("Enter a value in km: ");
            double km = double.Parse(Console.ReadLine());

            double m = 1000 * km;
            Console.WriteLine($"{km} kilometers is equal to {m} meters");
            Console.ReadKey();
        }
    }

       
}
