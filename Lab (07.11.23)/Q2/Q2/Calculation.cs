using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Calculation
    { 
        private double number1;
        private double number2;

        public void setValues(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public double getAdd()
        {
            return number1 + number2;
        }

        public double getSub()
        {
            return number1 - number2;
        }

        public double getMul()
        {
            return number1 * number2;
        }

        public double getDiv()
        {
            return number1 / number2;
        }
    }

}   

