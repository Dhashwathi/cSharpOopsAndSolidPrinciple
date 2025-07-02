// See https://aka.ms/new-console-template for more information

namespace MyConsoleApp1
{
    //Understanding Class and objects
    class Student
    {
        public String Studentname;                        //field
        public int rollNo;                                //field
        public int Totalmarks = 50;                       //field
        public void DisplayStudentActivity(String Studentname)   // method
        {
            Console.WriteLine(Studentname + " is unique");
        }
    }

    // Usage of Constructors
    class Employee
    {
        public String Employeename;
        public int EmployeeID;
        //Constructors
        public Employee(String EmpName, int EmpID)
        {
            Employeename = EmpName;
            EmployeeID = EmpID;
        }
    }
}

