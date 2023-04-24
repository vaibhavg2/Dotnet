//delegate void Action<T1, T2, ... T16>(T1 arg1, T2 args2, ... T16 arg16)
class Program
{
    static float SafeScheme(int y)
    {
        return y < 3 ? 6 : 7;
    }

    static void Main(string[] args)
    {
        Console.Write("Amount of Payment : ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Number of Payments: ");
        int n = int.Parse(Console.ReadLine());
        var inv = new Investment(p, n);
        //passing method-group
        Console.WriteLine("Future value of risk-free investment: {0:0.00}", inv.FutureValue(SafeScheme));
        //passing lambda-expression
        Console.WriteLine("Future value of riskful investment: {0:0.00}", inv.FutureValue(y => 9 + 0.25f * y));
        if(args.Length > 0)
        {
            Action<string> greet = s => Console.WriteLine($"Hi {s}");
            greet += s => Console.WriteLine($"Bye {s}");
            greet(args[0]); //multicast Invoke
        }
    }
}