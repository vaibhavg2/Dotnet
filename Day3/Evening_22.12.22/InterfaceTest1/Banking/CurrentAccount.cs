namespace Banking;

//a class defined with sealed modifier cannot be
//used as a base class for other classes
sealed class CurrentAccount : Account
{
    public override void Deposit(double amount)
    {
        Balance += amount;
    }

    public override void Withdraw(double amount)
    {
        Balance -= amount;
    }

}