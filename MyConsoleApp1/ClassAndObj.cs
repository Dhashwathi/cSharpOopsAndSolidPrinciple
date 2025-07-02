// See https://aka.ms/new-console-template for more information

namespace MyConsoleApp1
{
    //Understanding Class and objects
    class Student
    {
        public String name;                               //field
        public int rollNo;                                //field
        public int marks = 50;                            //field
        public void StudentActivity(String name)   // method
        {
            Console.WriteLine(name + " is unique");
        }
    }

    // Usage of Constructors
    class Employee
    {
        public String name;
        public int ID;
        //Constructors
        public Employee(String EmpName, int EmpID)
        {
            name = EmpName;
            ID = EmpID;
        }
    }
}

