namespace Taxation;

public struct Programmer : ITaxPayer
{
    private int lines;

    public Programmer(int lines)
    {
        this.lines = lines;
    }

    public double AnnualIncome()
    {
        return 300000 + 0.25 * lines;
    }
}
