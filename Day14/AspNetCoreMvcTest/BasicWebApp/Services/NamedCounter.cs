namespace BasicWebApp.Services;

public class NamedCounter : ICounter
{
    private static Dictionary<string, int> counters = new();

    public int CountNext(string key)
    {
        lock(counters)
        {
            counters.TryGetValue(key, out int current);
            counters[key] = ++current;
            return current;
        }
    }
}