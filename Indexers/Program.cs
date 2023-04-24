class Program
{
    public static void Main()
    {
        Employee emp = new Employee(1,"Saurabh","Full-stack", "Pune");
        Console.WriteLine("Employee ID : "+ emp[1]);
        Console.WriteLine("Employee Name : "+ emp[2]);
        Console.WriteLine("Employee Desg : "+ emp[3]);
        Console.WriteLine("Employee Place : "+ emp[4]);

        emp[1] = "Vaibhav";                                 //setting data;
        Console.WriteLine("After updating data : ");

        Console.WriteLine("Employee ID : "+ emp[1]);
        Console.WriteLine("Employee Name : "+ emp[2]);
        Console.WriteLine("Employee Desg : "+ emp[3]);
        Console.WriteLine("Employee Place : "+ emp[4]);

        Console.WriteLine($"Designation of {emp[1]} : " + emp["Vaibhav"]);
    }
}