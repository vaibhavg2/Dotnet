class Program
{
    class Computation
    {
        private System.Diagnostics.Stopwatch clock = new();

        public (long, double) Compute(int begin, int end)
        {
            clock.Start();
            long result = Enumerable.Range(begin, end - begin)
                            .Select(Worker.DoWork)
                            .Sum();
            clock.Stop();
            return (result, clock.Elapsed.TotalSeconds);
        }
    }

    static void DoComputation(int limit)
    {
        Console.Write("Computing...");
        var c = new Computation();
        (long r, double t) = c.Compute(1, limit + 1);
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, t);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        DoComputation(n);
    }
}