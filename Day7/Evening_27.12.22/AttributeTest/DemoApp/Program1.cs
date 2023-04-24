class Program
{
    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        Type t = Type.GetType(args[1]);
        //strict-typing is disabled for dynamic type and  
        //runtime-binding is generated for invocation of its members
        dynamic policy = Activator.CreateInstance(t);
        int m = 10;
        for(int n = 1; n <= m; ++n)
        {
            float i = policy.Common(p, n) / 1200; //duck typing
            double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
            Console.WriteLine("{0}\t{1:0.00}", n, emi);
        }
    }
}