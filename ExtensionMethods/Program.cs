namespace DemoExtension
{
    sealed class Program
    {
        public void Meth1()
        {
            Console.WriteLine("Method1");
        }
        public void Meth2()
        {
            Console.WriteLine("Method2");
        }
        public void Meth3()
        {
            Console.WriteLine("Method3");
        }

        public static void Main()
        {
            Program p = new Program();
            p.Meth1();
            p.Meth2();
            p.Meth3();
            p.Meth4();
            p.Meth5();
        }
    }
}