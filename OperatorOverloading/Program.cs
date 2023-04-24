namespace DemoOperatorOverloading
{   
    class NewClass
    {   
        public int x;
        public string s;

        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.x = obj1.x + obj2.x;
            obj3.s = obj1.s + obj2.s;
            return obj3;
        }
    }
    
    class Program
    {   
       public static void Main(string[] args)
       {
            NewClass obj1 = new NewClass();
            obj1.x = 10;
            obj1.s = "Bharat ";
            NewClass obj2 = new NewClass();
            obj2.x = 20;
            obj2.s = "Jodo";

            NewClass obj3 = new NewClass();
            obj3 =  obj1 + obj2;

            Console.WriteLine(obj3.x + "  " + obj3.s);
       }
    }
}