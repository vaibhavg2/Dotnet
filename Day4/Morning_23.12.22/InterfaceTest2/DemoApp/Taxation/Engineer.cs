namespace Taxation;

public struct Engineer : ITaxPayer
{
    private int projects;

    public Engineer(int projects)
    {
        this.projects = projects;
    }

    public double AnnualIncome()
    {
        return 500000 + 30000 * projects;
    }
}