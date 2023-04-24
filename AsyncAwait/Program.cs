namespace demoAsync
{
    class Program
    {
        public static void Main()
        {   
            method1();
            method2();
            method3();
            method4();
            Console.ReadKey();
        }

        //Synchronous way :

        // public static void method1()
        // {
        //     Console.WriteLine("Method 1 gets called.");
        //     Thread.Sleep(4000);
        //     Console.WriteLine("Method 1 completed.");
        // }
        // public static void method2()
        // {
        //     Console.WriteLine("Method 2 gets called.");
        //     Thread.Sleep(5000);
        //     Console.WriteLine("Method 2 completed.");
        // }
        // public static void method3()
        // {
        //     Console.WriteLine("Method 3 gets called.");
        //     Thread.Sleep(1000);
        //     Console.WriteLine("Method 3 completed.");
        // }
        // public static void method4()
        // {
        //     Console.WriteLine("Method 4 gets called.");
        //     Thread.Sleep(2000);
        //     Console.WriteLine("Method 4 completed.");
        // }

        //Asynchronous way:
        public static async void method1()
        {   
            await Task.Run(() => {
                Console.WriteLine("Method 1 gets called.");
                Thread.Sleep(4000);
                Console.WriteLine("Method 1 completed.");
            });
        }
        public static async void method2()
        {   
            await Task.Run(()=>{
                Console.WriteLine("Method 2 gets called.");
                Thread.Sleep(7000);
                Console.WriteLine("Method 2 completed.");
            });
        }
        public static async void method3()
        {   
            await Task.Run(()=>{
                Console.WriteLine("Method 3 gets called.");
                Thread.Sleep(1000);
                Console.WriteLine("Method 3 completed.");
            });
        }
        public static async void method4()
        {   
            await Task.Run(()=>{
                Console.WriteLine("Method 4 gets called.");
                Thread.Sleep(2000);
                Console.WriteLine("Method 4 completed.");
            });
        }
    }
}