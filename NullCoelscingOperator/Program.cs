namespace DemoNull
{
    class Program
    {
        static void Main()
        {
            string name1 = null;
            string result;
            
            // if(name1 != null)
            // {
            //     result = name1;
            //     Console.WriteLine(result);
            // }
            // instead of writing this much lines of code
            
            result = name1 ?? "anonymous";
            Console.WriteLine(result);

            /*
                - Null coelscing operator returns the left side value of the operator if it is not null
                - If it is null then right side value of the null operator will be returned.
            */
            
            // string name1 = null;
            // string name2 = null;
            // string name3 = "rushi";
            // string result = name1 ?? name2 ?? name3;
            // Console.WriteLine(result);



        }
    }
}