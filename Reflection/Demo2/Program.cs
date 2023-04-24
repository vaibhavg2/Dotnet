using System;
using System.Reflection;


namespace ReflectionDemo2{

    public class Program
    {
        public static void Main(string[] args)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type customerType = currentAssembly.GetType();
            object customerInstance = Activator.CreateInstance(customerType);
            MemberInfo getMethodName = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Saurabh";
            parameters[1] = "Technologies";

            string fullName = (string)getMethodName.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name : {0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string secondName)
        {
            return firstName + " " + secondName;
        }
    }
}