using System.Collections.Generic;

namespace DictionaryDemo
{   
    class Employee
    {
        public int Id{get;set;}
        public string name { get; set;}

        public string desg { get; set;}

        public int salary { get; set;}
    }
    class Program
    {
        public static void Main()
        {
            // Dictionary<string, string> MyDic = new Dictionary<string, string>();
            // MyDic.Add("Active", "ready to engage in activity");
            // MyDic.Add("Quarantine", "place of isolation");
            // MyDic.Add("Amazing", "causing of great surprise");

            // foreach(var i in MyDic)
            // {
            //     Console.WriteLine("Key is : "+i.Key + ", Value is : "+ i.Value);
            // }

            Employee emp1 = new Employee()
            {
                Id = 1,
                name = "Saurabh",
                desg = "Full-stack",
                salary = 7000
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                name = "vaibhav",
                desg = "Full-stack",
                salary = 9000
            };

            Dictionary<int,Employee> myEmp = new Dictionary<int, Employee>();
            myEmp.Add(emp1.Id, emp1);
            myEmp.Add(emp2.Id, emp2);

            foreach(KeyValuePair<int, Employee> i in myEmp)
            {
                Console.WriteLine(i.Key +" "+ i.Value.name+" "+ i.Value.desg+" "+ i.Value.salary);
            }

        }
    }
}