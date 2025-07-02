// See https://aka.ms/new-console-template for more information

using System;
using System.Drawing;

namespace MyConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            // creating Object for class Student
            Console.WriteLine("-------------Example for Class and Objects-----------------");
            Student StudentDhash = new Student();
            StudentDhash.Studentname = "Dhashwathi";
            StudentDhash.rollNo = 12;
            Console.WriteLine(StudentDhash.Studentname);
            Console.WriteLine(StudentDhash.rollNo);
            Console.WriteLine(StudentDhash.Totalmarks);
            StudentDhash.DisplayStudentActivity(StudentDhash.Studentname); //method call

            Student StudentSubi = new Student();
            StudentSubi.Studentname = "Subi";
            StudentSubi.rollNo = 33;
            Console.WriteLine(StudentSubi.Studentname);
            Console.WriteLine(StudentSubi.rollNo);
            Console.WriteLine(StudentSubi.Totalmarks);
            StudentSubi.DisplayStudentActivity(StudentSubi.Studentname);

            // usage of Constructors
            Console.WriteLine("------Example for Class and Objects using Constructors------");
            Employee Empobject = new Employee("Dhashwathi", 76);
            Employee EmpSubi = new Employee("Subi", 77);
            Console.WriteLine(Empobject.Employeename);
            Console.WriteLine(EmpSubi.Employeename);

            // Encapsulation
            Console.WriteLine("-----------Example for Encapsulation-------------");
            Worker workerObj = new Worker();
            workerObj.WorkerName = "Dhashwathi";
            workerObj.AddAmount(25000);
            workerObj.Deduct(5000);
            Console.WriteLine($"Employee Name: {workerObj.WorkerName}");
            Console.WriteLine($"Current Salary: {workerObj.Salary}");

            //Inheritance - Multi level 
            Console.WriteLine("---------Example for Inheritance-------------");
            Animal myDog = new Dog();
            myDog.AnimalSound();
            Animal myCat = new Cat();
            myCat.AnimalSound();
            Animal myCow = new Cow();
            myCow.AnimalSound();

            //Abstraction
            Console.WriteLine("-------Example for Abstraction------");
            Shape myShape = new Square(4);
            int result =myShape.AreaOfShape();
            Console.WriteLine("{0}", result);

            //Polymorphism
            Console.WriteLine("-------Example for Polymorphism-------");
            Calculator AddFunction =new Calculator();
            Console.WriteLine("Add(int, int): " + AddFunction.AdditionOfNumbers(5, 10));             
            Console.WriteLine("Add(int, int, int): " + AddFunction.AdditionOfNumbers(1, 2, 3));    
            Console.WriteLine("Add(double, double): " + AddFunction.AdditionOfNumbers(2.5, 4.3));   
            Console.WriteLine("Add(string, string): " + AddFunction.AdditionOfNumbers("7", "8"));

            //SOLID principle --------- SRP -------------
            Console.WriteLine("----------Example for Singe Responsibility Principle---------");
            User user = new User { Name = "John", HoursWorked = 40, HourlyRate = 20 };
            // Saving user data to file using a dedicated class
            UserDataSaver dataSaver = new UserDataSaver();
            dataSaver.SaveToFile(user);
            // Calculating salary using a dedicated class
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            Console.WriteLine("Salary: " + salaryCalculator.CalculateSalary(user));

            //-----OCP-------
            Console.WriteLine("----------Example for Open / Close Principle---------");
            PizzaBill bill = new PizzaBill();
            Console.WriteLine("Total: " + bill.PrintPizzaBill(new NormalPizza()));
            Console.WriteLine("Total: " + bill.PrintPizzaBill(new SpecialPizza()));
        }
    }
}
