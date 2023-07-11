using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to num1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value to num2: ");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calobj = new Calculation();

            calobj.setValues(num1, num2);

            Console.WriteLine("Sum: " + calobj.getAdd());
            Console.WriteLine("Sub: " + calobj.getSub());
            Console.WriteLine("Mul: " + calobj.getMul());
            Console.WriteLine("Div: " + calobj.getDiv());
        }

    }
}
