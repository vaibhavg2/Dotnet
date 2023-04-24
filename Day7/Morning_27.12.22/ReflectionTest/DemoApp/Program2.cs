class Program
{
    static void Present(object info)
    {
        Type t = info.GetType();
        Console.WriteLine("<{0}>", t.Name);
        foreach(var prop in t.GetProperties())
            Console.WriteLine("  <{0}>{1}</{0}>", prop.Name, prop.GetValue(info));
        Console.WriteLine("</{0}>", t.Name);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Present(Shop.CreateItem("cpu"));
        Present(Shop.CreateItem("ddr"));
        Present(Shop.CreateCustomer("Jack"));
    }
}