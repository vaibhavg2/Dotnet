namespace Finance;


public class HomeLoan
{
    public float Common(double amount, int period)
    {
        return amount < 500000 ? 9 : 8.5f;
    }

    [MaxDuration(Limit = 12)]
    public float Woman(double amount, int period) => Common(amount, period) - 1;

    public float Soldier(double amount, int period) => Common(amount, period) / 2;
}
