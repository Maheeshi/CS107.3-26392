using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_ascending_descending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 122, 45, 56, 49, 326, 15, 45, 945, 153 };

            for (int i = 0; i < num.Length; i++) 
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[i] + 1) 
                    { 
                        int temp = num[i];
                        num[j] = num[j+1];  
                        num[j + 1] = temp;
                    }
                        
                }
            }
            for(int i = 0;i < num.Length; i++) 
            {
                Console.Write(num[i] + "");
            }
        }
    }
}
