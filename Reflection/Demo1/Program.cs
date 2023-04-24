using System.Reflection;

namespace ReflectionDemo
{

class Program
{
    public static void Main()
    {   
        // Customer c1 = new Customer();
        // Type t = c1.GetType();
        // Type t = Type.GetType("ReflectionDemo.Customer");
        Type t = typeof(Customer);
        Console.WriteLine("Full Name : {0}", t.FullName);
        Console.WriteLine("Name : {0}", t.Name);
        Console.WriteLine("Namespace : {0}", t.Namespace);

        Console.WriteLine("Properties : ");
        var props = t.GetProperties();
        foreach(PropertyInfo p in props)
            Console.WriteLine(p.PropertyType.Name+ " : " +p.Name);

        Console.WriteLine("Methods :");
        MethodInfo[] meths = t.GetMethods();
        foreach(MethodInfo m in meths)
           Console.WriteLine(m.ReturnType.Name+ " : " +m.Name);

        Console.WriteLine("Constructors : ");
        ConstructorInfo[] cons = t.GetConstructors();
        foreach(ConstructorInfo c in cons)
            Console.WriteLine(c.ToString());

    }
}

class Customer
{   
    public int Id {get; set;}
    public string Name {get; set;}

    public Customer()
    {

    }
    public Customer(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }

    public void PrintId()
    {
        Console.Write(Id);
    }

    public void PrintName()
    {
        Console.Write(Name);
    }

}
}