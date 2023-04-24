namespace DemoGenerics
{   
    class Program
    {   

        // public static void Print(int a)
        // {
        //     Console.WriteLine(a);
        // }

        // public static void Print(string a)
        // {
        //     Console.WriteLine("This "+a);
        // }

        //Rather than having two different methods we can have one single method which will work for all the types.
        //codereusability
        //code gets reduced.
        //Type safety.

        public static void Print<T>(T a)            //A generic method which will take parameter of type <T>
        {
            Console.WriteLine(a);
        }
        
        public static void Main(string []args)
        {
            Program.Print(7);
            Program.Print("Saurabh");
            Program.Print("Tajane");
        }
    }
}