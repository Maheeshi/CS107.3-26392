using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.Write("Enter a value to num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a value to num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("The summation is: " + sum);
            Console.ReadLine();
        }
    }
}
