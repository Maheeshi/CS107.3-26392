using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_name_batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your batch: ");
            int batch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + "and your batch is " + batch);

            Console.ReadKey();
        }
    }
}
