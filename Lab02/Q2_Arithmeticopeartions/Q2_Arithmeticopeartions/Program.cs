using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Arithmeticopeartions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1,num2;
            char opeartion;

            Console.Write("Enter a value to num1: ");
            num1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value to num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+,-,*,/): ");
            opeartion = Convert.ToChar(Console.ReadLine());

            if (opeartion == '+' )
            {
                Console.Write("The sum of num1 and num2: " + (num1 + num2));
            }
            else if(opeartion == '-')
            {
                Console.Write("The diffence of num1 and num2: " + (num1 - num2));
            }
            else if (opeartion == '*')
            {
                Console.Write("The multipaction of num1 and num2: " + (num1 * num2));
            }
            else if (opeartion == '/')
            {
                Console.Write("The division of num1 and num2: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
            Console.ReadLine();
        }
    }
}
