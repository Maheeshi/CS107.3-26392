using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Q6_array
{
    internal class array
    {
        public int[] arrayMethod(int size)
        {
            int[] myArray = new int[size];

            for (int i = 0; i< myArray.Length; i += 2)
            {
                Console.WriteLine("Enter a valeu: ");
                int value = Convert.ToInt32(Console.ReadLine());

                myArray[i] = value;
                myArray[i + 1] = 0;
            }
            return myArray;
        }
       
    }
}
