using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area, circumference;

            Console.Write("Enter a value to radius: ");
            radius = double.Parse(Console.ReadLine());

            area = Math.PI * radius * radius;
            circumference = Math.PI * 2 * radius;

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " +  circumference);

            Console.ReadLine();
        }

        
    }
}
