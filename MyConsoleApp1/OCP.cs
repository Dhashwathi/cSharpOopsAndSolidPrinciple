using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    public interface IPizza
    {
        int GetPrice();
    }
    public class NormalPizza : IPizza
    {
        public int GetPrice() => 100;
    }

    public class SpecialPizza : IPizza
    {
        public int GetPrice() => 150;
    }
    public class PizzaBill
    {
        public int PrintBill(IPizza pizza)
        {
            return pizza.GetPrice();
        }
    }

}
