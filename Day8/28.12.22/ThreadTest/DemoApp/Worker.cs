static class Worker
{
    public static void DoWork(int count)
    {
        int future = Environment.TickCount + 1000 * count;
        while(Environment.TickCount < future);
    }
}