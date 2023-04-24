class Program
{
    private static void Print(string label, object info)
    {
        Console.WriteLine("{0} = {1}", label, info.ToString());
    }

    public static void Main(string[] args)
    {
        Interval a = new Interval(6, 5);
        Interval b = new Interval(4, 30);
        Interval c = new Interval(5, 65);
        Interval d = b;
        Print("Interval a", a);
        Print("Interval b", b);
        Print("Interval c", c);
        Print("Interval d", d);
    }
}