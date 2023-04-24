namespace DelegateDemo2
{   
    public delegate void DelegateRectangle(int width, int height);
    class Program
    {   
        public void RectangleArea(int x, int y)
        {
            Console.WriteLine($"Area : {x*y}");
        }
        public void RectanglePerimeter(int x, int y)
        {
            Console.WriteLine($"Perimeter : {2*(x+y)} ");
        }
        
        public static void Main()
        {
            Program p = new Program();
            DelegateRectangle d = p.RectangleArea; 
            //This single delegate is referencing to the two methods
            d += p.RectanglePerimeter;
            d.Invoke(10,12);
        }
    }
}
            //If methods having same no and types of parameters then we should go for Multicasting delegate.
            //Remember return type of all the methods the delegate is referencing should be void.
            //If methods are returning the values then the last method which will be invoked the value of that 
            //method will come as output.