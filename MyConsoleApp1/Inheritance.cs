using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    class Animal // Base class
    {
        public virtual void speak() //Achieves Overriding 
        {
            Console.WriteLine("All animals make a sound");
        }
    }
    class Dog : Animal //child class-1
    {
        public override void speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat : Animal // Child Class-2
    {
        public override void speak()
        {
            Console.WriteLine("cat Meow Meow");
        }
    }
    class Cow : Animal // Child Class-3
    {
        public override void speak()
        {
            Console.WriteLine("Cow MA.. MA.. MA");
        }
    }

}
