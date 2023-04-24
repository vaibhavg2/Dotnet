class Program
{
    static string Select(int index, string first, string second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    static double Select(int index, double first, double second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = Select(s, "Monday", "Friday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(s, 43.1, 56.7);
            Console.WriteLine($"Selected double = {sd}");
            //double dsd = Select(s, "Monday", 56.7);
        }
    }
}