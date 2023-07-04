using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            array objarray = new array();
            int[] myArray = objarray.arrayMethod(size); 
            //through the object calling the array method
            //return type is int[] 

            Console.WriteLine("\nDisplay the array: ");
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write(myArray[i] + "");
            }
            Console.ReadLine();
        }
    }
}
