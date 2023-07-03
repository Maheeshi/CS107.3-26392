using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_areaofcircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.Write("Enter a value to radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

           area = Math.PI * radius * radius;

            Console.WriteLine("Area of the circle: " + area);
            Console.ReadLine();
        }
    }
}
