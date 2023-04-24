delegate float InterestRate(int period);
class Investment
{
    public double Payment { get; }

    public int Count { get; }

    public Investment(double amount, int years)
    {   
        Payment = amount;
        Count = years;
    }

    public double FutureValue(InterestRate rate)
    {
        float i = rate.Invoke(Count) / 100;
        return (Payment / i) * (Math.Pow(1 + i, Count) - 1);
    }
}