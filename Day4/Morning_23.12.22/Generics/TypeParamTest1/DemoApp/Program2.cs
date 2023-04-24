class Program
{
    static object Select(int index, object first, object second)
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
            string ss = (string)Select(s, "Monday", "Friday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = (double)Select(s, 43.1, 56.7);
            Console.WriteLine($"Selected double = {sd}");
            double dsd = (double)Select(s, "Monday", 56.7);
        }
    }
}