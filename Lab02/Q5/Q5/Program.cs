using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter 10 numbers");

            for (int i = 1; i <=10; i++) 
            {
                Console.Write($"Enter a value to {i}: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The value entered is even");
                }
                else
                {
                    Console.WriteLine("The value entered is odd");
                }
            }
            Console.ReadLine();
        }
    }
}
