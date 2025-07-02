using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    abstract class Shape
    {
        //abtracted method
        public abstract int AreaOfShape();
    }
    class Square : Shape
    {
        int sideOfShape;

        public Square(int ActualSideOfShape)
        {
            sideOfShape = ActualSideOfShape;
        }

        //expanding the abstract method
        public override int AreaOfShape()
        {
            Console.Write("Area of a Square: ");
            return (sideOfShape*sideOfShape);
        }
    }
}
