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

        public Task<(long, double)> ComputeAsync(int begin, int end)
        {
            //Run the specified operation as an asynchronous task
            //(in a pooled thread) without blocking the caller thread
            //while allowing it to obtain the result of the operation
            //once its running task is completed.
            return Task<(long, double)>.Run(() => Compute(begin, end));
        }
    }

    static Task DoComputation(int limit)
    {
        Console.Write("Computing...");
        var c = new Computation();
        return c.ComputeAsync(1, limit + 1)
                .ContinueWith(completed => 
                {
                    (long r, double t) = completed.Result;
                    Console.WriteLine("Done!");
                    Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, t);                    
                });
    }

    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        var job = DoComputation(n);
        while(!job.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}