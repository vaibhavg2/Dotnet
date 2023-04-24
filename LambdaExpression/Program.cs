namespace LambdaDemo
{   
    public delegate void printName(string name);
    class Program
    {
        public static void Main(string[] args)
        {   
            Program p = new Program();
            // printName d = delegate (string name)   ////Anonymous  Method
            // {
            //     Console.WriteLine(name);
            // };
            printName d = name => {Console.WriteLine(name);};
            d.Invoke("saurabh");
        }
    }
}