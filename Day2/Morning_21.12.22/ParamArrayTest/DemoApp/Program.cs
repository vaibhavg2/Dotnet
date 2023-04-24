class Program
{
    /*
    private static double Average(double first, double second)
    {
        return (first + second) / 2;
    }

    private static double Average(double first, double second, double third)
    {
        return (first + second + third) / 3;
    }
    */

    //variadic method
    private static double Average(double first, double second, params double[] remaining)
    {
        double total = first + second;
        foreach(double value in remaining)
            total += value;
        return total / (2 + remaining.Length);
    }

    //'out' modifier is same as 'ref' but it can accept uninitialized argument
    //which must be initialized by the method before it returns
    
    private static double AverageWithDeviation(double first, double second, out double deviation)
    {
        deviation = first > second ? (first - second) / 2 : (second - first) / 2;
        return Average(first, second);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Average of two values: {0}", Average(43.2, 38.7));
        Console.WriteLine("Average of three values: {0}", Average(43.2, 38.7, 29.4));
        //Console.WriteLine("Average of five values: {0}", Average(43.2, 38.7, new double[]{29.4, 52.8, 17.1}));
        Console.WriteLine("Average of five values: {0}", Average(43.2, 38.7, 29.4, 52.8, 17.1));
        if(args.Length > 1)
        {
            double a = double.Parse(args[0]);
            double b = double.Parse(args[1]);
            double c = AverageWithDeviation(a, b, out double d);
            Console.WriteLine("Average is {0} with a deviation of {1}", c, d);
        }
    }
}
