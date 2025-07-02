using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    public class Worker
    {
        private int salary; // Access modifier
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

        public string WorkerName { get; set; }

        // Adding Amount to Salary
        public void AddAmount(int amount)
        {
            if (amount > 0)
            {
                Salary += amount;
            }
        }
        //Deducting from Salary
        public void Deduct(int amount)
        {
            if (amount > 0 && amount <= salary)
            {
                Salary -= amount;
            }
        }
    }
}
