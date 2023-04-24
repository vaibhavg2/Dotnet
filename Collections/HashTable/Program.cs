using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id",1);
            ht.Add("Name","saurabh");
            ht.Add("Salary","$7000");
            ht.Add("Marital Status",false);
            ht.Add("Designation", "FullStack Developer");

            foreach(var i in ht.Keys)
            {
                Console.WriteLine(i + " : "+ ht[i]);
            }
            Console.WriteLine("------------");
            foreach(var i in ht.Keys)
            {
                Console.WriteLine("Hashcode of : " +i + " : "+ ht[i].GetHashCode());
            }
            
        }
    }
}