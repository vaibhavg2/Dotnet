namespace Taxation;

public interface ITaxPayer
{
    double AnnualIncome();

    double IncomeTax()
    {
        double extra = AnnualIncome() - 120000;
        return extra > 0 ? 0.15 * extra : 0;
    }
}