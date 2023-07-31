using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value in km: ");
            int km = Convert.ToInt32(Console.ReadLine());

            ConvertValue obj = new ConvertValue();
            obj.kilometerTOmeter();

            Console.ReadLine();


        }
    }
}
