using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    //interface
    public interface IPizza
    {
        int GetPizzaPrice();
    }
    public class NormalPizza : IPizza
    {
        public int GetPizzaPrice() => 100;
    }

    public class SpecialPizza : IPizza
    {
        public int GetPizzaPrice() => 150;
    }
    public class PizzaBill
    {
        public int PrintPizzaBill(IPizza pizza)
        {
            return pizza.GetPizzaPrice();
        }
    }

}
