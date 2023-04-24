using System.Collections.Generic;
namespace ListDemo
{   
    class Employee
    {
        public string name{get; set;}
        public string desg{get; set;}
        public int age{get; set;}
    }
    class Program
    {
        public static void Main()
        {   
            Employee emp1 = new Employee()
            {
                name = "saurabh",
                desg = "Full-stack Developer",
                age = 24
            };

            Employee emp2 = new Employee()
            {
                name = "Rushi",
                desg = "Full-stack Developer",
                age = 26
            };

            Employee emp3 = new Employee()
            {
                name = "Vaibhav",
                desg = "Front-End Developer",
                age = 24
            };
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            foreach(var i in empList)
            {
                Console.WriteLine("Employee Name : {0}, Designation : {1}, Age : {2}", i.name,i.desg,i.age);
            }

            // List<int> myNum = new List<int>();
            // myNum.Add(10);
            // myNum.Add(100);
            // myNum.Add(1000);
            // myNum.Add(100);
            // myNum.Add(10);
            // foreach(int i in myNum)
            // {
            //     Console.WriteLine(i);
            // }

            // List<string> names = new List<string>();
            // names.Add("sau");
            // names.Add("sau1");
            // names.Add("sau2");
            // foreach(string i in names)
            // {
            //     Console.WriteLine(i);
            // }

        }
    }
}