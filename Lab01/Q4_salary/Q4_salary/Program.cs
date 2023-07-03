using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double old_salary, new_salary, tax;

            Console.Write("Enter the old salary: ");
            old_salary = double.Parse(Console.ReadLine());

            Console.Write("Enter the tax amount: ");
            tax= double.Parse(Console.ReadLine());

            new_salary = old_salary - tax;

            Console.Write("The new salary is: " + new_salary);
            Console.ReadLine();
        }
    }
}
