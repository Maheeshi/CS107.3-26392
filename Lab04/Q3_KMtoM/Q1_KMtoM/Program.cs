using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_KMtoM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value in km: ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double m = converter.KilometerTOmeter(km); // we store the returned meter value in the m variable.

            Console.WriteLine($"{km} kilometers is equal to {m} meters");
            Console.ReadKey();

        }
    }
}
