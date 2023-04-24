using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DemoSerialization
{   
    [Serializable]
    class Employee
    {
        public int Id;
        public string Name;

        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    [Obsolete]
    class Program
    {

        public static void Main()
        {       

            //Serialization

            // Employee emp = new Employee(31,"saurabh");
            // string path = @"D:\DAC\Hussain sir's Dotnet\Self\Serialization\DemoFolder\SampleText.txt";
            // FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // BinaryFormatter bf = new BinaryFormatter();
            // bf.Serialize(fs,emp);
            // fs.Close();
            // Console.WriteLine("File created successfully -> "+ path);

            // DeSerialization

            string path = @"D:\DAC\Hussain sir's Dotnet\Self\Serialization\DemoFolder\SampleText.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee) bf.Deserialize(fs);
            Console.WriteLine($"Employee ID : {emp.Id}");
            Console.WriteLine($"Employee Name : {emp.Name}");
        }
    }
}