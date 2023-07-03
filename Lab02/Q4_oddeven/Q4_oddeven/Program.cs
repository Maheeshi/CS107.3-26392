using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a value to num: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("The value you entered is even");
            }
            else
            {
                Console.WriteLine("The value you entered is odd");
            }
            Console.ReadLine();
        }
    }
}
