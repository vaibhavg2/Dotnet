class Program
{
    static string client;

    static void HandleJob(int jid)
    {
        Console.WriteLine("Thread<{0}> has accepted job<{1}> for client<{2}>.", Thread.CurrentThread.ManagedThreadId, jid, client);
        Worker.DoWork(jid);
        Console.WriteLine("Thread<{0}> has finished job<{1}> for client<{2}>.", Thread.CurrentThread.ManagedThreadId, jid, client);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        Thread child = new Thread(() =>
        {
            client = "Jack";
            HandleJob(n);
        });
        child.Start();
        client = "Jill";
        HandleJob(2);
    }
}