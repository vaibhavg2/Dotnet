static class Printable
{
    //A fluent function is method which returns a result
    //to which other such functions can be applied
    public static IEnumerable<string> Capitalize<T>(this IEnumerable<T> source)
    {
        foreach(var item in source)
            yield return item.ToString().ToUpper();
    }

    public static void PrintEach(this IEnumerable<string> source)
    {
        foreach(var item in source)
            Console.WriteLine(item);
    }
}
