class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Withdraw(int amount)
        {
            bool success = false;
            //Assign the specified object (this) its own separate monitor if required, 
            //allow the current thread to lock this monitor and continue execution. 
            //Only one thread can lock the monitor assigned to a given object at a 
            //time while other threads must wait for this thread to unlock that monitor.
            Monitor.Enter(this);
            try
            {
                if(Balance >= amount)
                {
                    Balance = Worker.DoWork(Balance, amount, -1);
                    success = true;
                }
            }
            finally
            {
                //unlock monitor assigned to specified (this) object
                Monitor.Exit(this); 
            }
            return success;
        }

        public void Deposit(int amount)
        {
            lock(this)
            {
                Balance = Worker.DoWork(Balance, amount, 1);
                Monitor.Pulse(this); //pulse monitor assigned to this object
            }
        }

        public bool WitdrawAfterDeposit(int amount)
        {
            lock(this)
            {
                //Unlock the monitor assigned to this object and wait
                //for this monitor to be pulsed by some other thread
                Monitor.Wait(this);
            }
            return Withdraw(amount);
        }
    }

    static void Main(string[] args)
    {
        var acc = new JointAccount();
        acc.Deposit(5000);
        Console.WriteLine("Joint account opened for Jack and Jill.");
        Console.WriteLine("Initial Balance = {0}", acc.Balance);
        var child = new Thread(() =>
        {
            Console.WriteLine("Jack is withdrawing 3000...");
            if(acc.Withdraw(3000) == false)
                Console.WriteLine("Jack's withdrawal failed!");
        });
        child.Start();
        Console.WriteLine("Jill is withdrawing 4000...");
        if(acc.Withdraw(4000) == false)
            Console.WriteLine("Jill's withdrawal failed!");
        child.Join(); //wait for child to exit
        Console.WriteLine("Final Balance = {0}", acc.Balance);        
    }
}