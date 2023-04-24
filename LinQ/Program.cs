namespace DemoLinQ
{
    class Program
    {
        // public static void Main()
        // {
        //     List<int> list = new List<int>(){1,3,4,5,2};
        //     var result = from l in list
        //                  where l >= 3
        //                  select l;

        //     foreach(int r in result)
        //         Console.WriteLine(r);
        // }

        public static void Main()
        {
            List<string> str = new List<string>(){"saurabh","vaibhav","ashish","rushikesh"};
            var result = from s in str
                         where s.Contains("saurabh")
                         select s;
            // Console.WriteLine(result);
            foreach(string s in result)
                    Console.WriteLine(s);
        }

        // static void Main(string[] args)
        // {
        //     List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //     //Method Syntax
        //     IEnumerable<int> filteredData = intList.Where(num => num > 5);
        //     //Query Syntax
        //     IEnumerable<int> filteredResult = from num in intList
        //                                       where num > 5
        //                                       select num;
            
        //     foreach (int number in filteredData)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }
    }
}