using Taxation;

class Program
{

    //nested class - can only refer to static members 
    //of outer class
    class Auditor : IDisposable
    {
        public Auditor()
        {
            Console.WriteLine("Acquiring resources...");
        }

        public void Audit(string id, ITaxPayer info)
        {
            if(id.Length < 4)
                throw new ArgumentException("Invalid ID");
            double payment = info.IncomeTax() + 500;
            Console.WriteLine("Total tax payment: {0:0.00}", payment);
        }

        public void Dispose()
        {
            Console.WriteLine("Releasing resources...");
        }
    }

    static void Process(string name, int count)
    {
        ITaxPayer t = count < 20 ? new Engineer(count) : new Programmer(count);
        using(Auditor a = new Auditor())
        {
            a.Audit(name, t);
        }//a.Dispose() will be called here
    }

    static void Main(string[] args)
    {
        try
        {
            string m = args[0].ToUpper();
            int n = int.Parse(args[1]);
            Process(m, n);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}