namespace Banking;

public interface IProfitable 
{
    static readonly double MinRate = 4;
    
    double AddInterest(int months);
}

