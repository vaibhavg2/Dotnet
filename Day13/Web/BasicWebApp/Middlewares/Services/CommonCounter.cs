namespace BasicWebApp.Services;

public class CommonCounter : ICounter
{
    private int current = 0;

    public int CountNext(string key)
    {
        return Interlocked.Increment(ref current);
    }
}