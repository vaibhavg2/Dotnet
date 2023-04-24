namespace PartialDemo
{
    partial class Program
    {
        int x = 10, y = 12;
        String s = "saurabh";
        public void print()
        {
            Console.WriteLine($"Name = {s}, number = {x}");
        }
        public partial void AddNum();
    }
    partial class Program
    {
        public void printMul()
        {
            Console.WriteLine("Multiplication = "+x*y);
        }
 
        public partial void AddNum()
        {
            Console.WriteLine("Addition = "+(x+y));
        }
        static void Main()
        {
            Program p = new Program();
            p.print();
            p.printMul();
            p.AddNum();
        }
    }
}