static class Worker
{
    public static int DoWork(int balance, int amount, int op)
    {
        int future = Environment.TickCount + amount / 1000;
        while(Environment.TickCount < future);
        return balance + op * amount;
    }
}