using System.Collections;

namespace QueueDemo
{
    class Program
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);
            q.Enqueue(null);
            foreach(var i in q)
                Console.WriteLine(i);

            while(q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }


        }
    }
}