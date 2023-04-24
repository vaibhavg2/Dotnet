namespace DemoLinQ
{
    class Program
    {
        public static void Main()
        {
            List<string> str = new List<string>(){"saurabh","vaibhav","ashish","rushikesh"};
        
            var result = from s in str
                        .AsParallel()                //parallelism
                        .AsOrdered()                 //Maintaining the order
                        where s.Contains('s')        //Filtering
                        select s;
            foreach(string s in result)
                    Console.WriteLine(s);

        }

    //     static void Main(string[] args)
    //     {
    //         //Creating a Collection of integer numbers
    //         var numbers = Enumerable.Range(1, 20);
            
    //         //Fetching the List of Even Numbers using PLINQ
    //         //PLINQ means we need to use AsParallel() to perform parallel operation
    //         var evenNumbers = numbers
    //                           .AsParallel()             //Parallel Processing
    //                           .AsOrdered()              //Original Order of the numbers
    //                           .Where(x => x % 2 == 0)
    //                           .ToList();
                              
    //         Console.WriteLine("Even Numbers Between 1 and 20");
    //         foreach (var number in evenNumbers)
    //         {
    //             Console.WriteLine(number);
    //         }
    //    }
    }
}