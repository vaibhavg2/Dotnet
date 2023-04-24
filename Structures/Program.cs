namespace  StructureDemo
{    
    interface Istruct
    {
        void show();
    }
    //Demo-1
    struct myProgram
    {   
        public void Func1()
        {
            Console.WriteLine("Hello");
        }
    public static void Main()
    {   
        // Program p = new Program();       //new keyword is not mandatory while initializing struct type 
        myProgram p;
        p.Func1();
    }

    //Demo-2

    struct Program : Istruct                //In structs inheritance is only possible through interfaces
    {   
        public void show()
        {
            
        }
        public static void Main()
        {
            Program p = new Program();
        }
    }
    }
}