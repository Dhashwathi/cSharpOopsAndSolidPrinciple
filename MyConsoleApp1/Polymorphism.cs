using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Add(int number1, int number2 , int number3)
        {
            return number1 + number2+ number3;
        }
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public int Add(string number1, string number2)
        {
            return int.Parse(number1) + int.Parse(number2);
        }
    }

}
