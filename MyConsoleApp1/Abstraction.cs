using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    abstract class Shape
    {
        public abstract int Area();
    }
    class Square : Shape
    {
        int side;

        public Square(int ActualSide)
        {
            side = ActualSide;
        }
        public override int Area()
        {
            Console.Write("Area of a Square: ");
            return (side*side);
        }
    }
}
