using System.Collections;

namespace  ArrayListDemo
{
    class Program
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            Console.WriteLine(list.Capacity);
            list.Add(20);
            list.Add("saurabh");
            list.Add(21);
            Console.WriteLine(list.Capacity);

            foreach(var i in list)
                Console.WriteLine(i);

            list.Remove("saurabh");
            Console.WriteLine("After removing :");
            foreach(var i in list)
                Console.WriteLine(i);
        }
    }
}