namespace DemoAnonymous
{   
    public delegate void DelegatePrint(string name);
    public delegate void DelegateFact(int num);

    class Program
    {
        // public void printName(string name)
        // {
        //     Console.WriteLine("Name is : "+name);
        // }

        static void Main(string[] args)
        {
            // Program p = new Program();
            DelegatePrint d = delegate (string name)
            {
                Console.WriteLine("Name is : "+name); 
                //anonymous method .... method without name or you can say a method which only have body
            };
            d.Invoke("Saurabh");

            DelegateFact f = delegate(int num)
            {   
                int fact = 1;
                while(num!=0)
                {
                    fact *= num;
                    num--;
                }
                Console.WriteLine($"Factorial of num is : {fact}");
            };
            int n = int.Parse(args[0]);
            f.Invoke(n);
        }
    }
}