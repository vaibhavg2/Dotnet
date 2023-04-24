class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Withdraw(int amount)
        {
            bool success = false;
            if(Balance >= amount)
            {
                Balance = Worker.DoWork(Balance, amount, -1);
                success = true;
            }
            return success;
        }

        public void Deposit(int amount)
        {
            Balance = Worker.DoWork(Balance, amount, 1);
        }
    }

    static void Main(string[] args)
    {
        var acc = new JointAccount();
        acc.Deposit(5000);
        Console.WriteLine("Joint account opened for Jack and Jill.");
        Console.WriteLine("Initial Balance = {0}", acc.Balance);
        Console.WriteLine("Jack is withdrawing 3000...");
        if(acc.Withdraw(3000) == false)
            Console.WriteLine("Jack's withdrawal failed!");
        Console.WriteLine("Jill is withdrawing 4000...");
        if(acc.Withdraw(4000) == false)
            Console.WriteLine("Jill's withdrawal failed!");
        Console.WriteLine("Final Balance = {0}", acc.Balance);        
    }
}