using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Encapsulation
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public void setempID(int input)
        {
            empID = input;
        }

        public void setempName(string input)
        {
            empName = input;
        }
        public void setempDesignation(string input)
        {
            empDesignation = input;
        }
        //getter(read variable)
        public int getempID()
        {
            return empID;
        }
        public string getempName()
        {
            return empName;
        }
        public string getempDesignation()
        {
            return empDesignation;
        }
    }
}


    // we can do all these in a single method but if we want to update this we have ti change everythinh