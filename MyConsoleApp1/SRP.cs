using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    // Class responsible for storing employee data
    public class User
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
    }

    // Class responsible for saving employee data
    public class UserDataSaver
    {
        public void SaveToFile(User user)
        {
            File.WriteAllText("User.txt", $"Name: {user.Name}, Hours Worked: {user.HoursWorked}, Hourly Rate: {user.HourlyRate}");
            Console.WriteLine("User data saved to file.");
        }
    }

    // Class responsible for salary calculations
    public class SalaryCalculator
    {
        public decimal CalculateSalary(User user)
        {
            return user.HoursWorked * user.HourlyRate;
        }
    }

}


