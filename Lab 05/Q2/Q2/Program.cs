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
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value to num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Class1 objclass= new Class1();
            objclass.Setnum1(num1);
            Console.WriteLine("The value for num1 is " + objclass.Getnum1());

            objclass.Setnum2(num2);
            Console.WriteLine("The value for num2 is " + objclass.Getnum2());

            Console.ReadLine();
        }
    


    }
}
