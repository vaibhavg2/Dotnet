using System.Collections;

namespace StackDemo
{
    class Program
    {
        public static void Main()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);
            foreach(var i in st)
                Console.WriteLine(i);
            st.Pop();
            Console.WriteLine("After removing :");
            foreach(var i in st)
                Console.WriteLine(i);

        }
    }
}