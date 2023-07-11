using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Designation: ");
            string empDesignation = Console.ReadLine();

            Employee empobj = new Employee();

            empobj.setempID(empID);
            empobj.setempName(empName);
            empobj.setempDesignation(empDesignation);

            Console.WriteLine("Hello" + empobj.getempName() + "Your Empolyee ID is" + empobj.getempID() + "and you are a" + empobj.getDesination());


        }
    }
}
