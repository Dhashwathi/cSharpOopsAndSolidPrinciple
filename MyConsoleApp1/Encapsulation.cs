using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    public class Worker
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
            private set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }
        public string Name { get; set; }
        public void AddAmount(int amount)
        {
            if (amount > 0)
            {
                Salary += amount;
            }
        }
        public void Deduct(int amount)
        {
            if (amount > 0 && amount <= salary)
            {
                Salary -= amount;
            }
        }
    }
}
