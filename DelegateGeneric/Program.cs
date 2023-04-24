namespace GenericDelegateDemo
{
    class Program
    {   
        public static void print(int n)
        {
            Console.WriteLine("Likh diya..");
        }

        public static int print(int n, int m)
        {
            return n + m;
        }

        public static bool print(string s)
        {
            return s.Length == 7;
        }

        public static void Main()
        {
            Action<int> obj = new Action<int>(print);
            obj.Invoke(3);
            //Action can one or more inputs but doesnot return any value;

            Func<int,int,int> obj1 = new Func<int, int, int>(print);
            Console.WriteLine(obj1.Invoke(10,12));
            //Func also take one or more input types but return one value defined in the last type of parameter

            Predicate<string> obj2 = new Predicate<string>(print);
            Console.WriteLine(obj2.Invoke("saurabh")); 
            //Predicate takes only one parameter and return boolean value
            //No need to mention return type as by default it is bool
        }
    }
}