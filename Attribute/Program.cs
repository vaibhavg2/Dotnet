class Calculator
{   
    [Obsolete("This method is obsolete use newer one", false)]  //Attribute
    // This will generate warning if false, if true then it will show error.
    public static int Add(int first, int second)
    {
        return first + second;
    }

    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach(int num in Numbers)
            sum+=num;
        return sum;
    }
}
class Program
{
    public static void Main()
    {
       Console.WriteLine(Calculator.Add(10,20)); 
    }
}
