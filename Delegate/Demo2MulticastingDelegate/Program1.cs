    /*If methods having same no and types of parameters then we should go for Multicasting delegate.
    Remember return type of all the methods the delegate is referencing should be void.
    If methods are returning the values then the last method which will be invoked the value of that 
    method will come as output.*/
namespace DelegateDemo2_2
{   
    public delegate double DelegateRectangle(int width, int height);
    class Program
    {   
        public double RectangleArea(int x, int y)
        {
            return x*y;
        }
        public double RectanglePerimeter(int x, int y)
        {
            return 2*(x+y);
        }
        
        public static void Main()
        {
            Program p = new Program();
            DelegateRectangle d = p.RectangleArea; 
            //This single delegate is referencing to the two methods
            d += p.RectanglePerimeter;
            double result = d.Invoke(10,12);
            Console.WriteLine("Result : "+result);
        }
    }
}