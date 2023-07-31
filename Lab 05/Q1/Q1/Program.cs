using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapclass ec = new Encapclass();
            ec.SetAge(25);
            ec.SetName("Maheeshi");
            Console.WriteLine("Your age is " + ec.getAge());
            Console.WriteLine("Your name is " + ec.getName());
            Console.ReadLine();
        }
    }
}
