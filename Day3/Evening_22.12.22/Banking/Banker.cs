namespace Banking;

//a class defined with static modifier can only
//contain static members and as such it does
//not support activation
public static class Banker
{
    private static long nid;

    //a static constructor of a class is invoked once when this class
    //is used for the first time within the executing assembly
    static Banker()
    {
        nid = DateTime.Now.Ticks % 1000000;
    }

    public static Account OpenCurrentAccount()
    {
        var acc = new CurrentAccount(); //var = CurrentAccount
        acc.Id = ++nid + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        SavingsAccount acc = new ();
        acc.Id = ++nid + 200000000;
        return acc;
    }

    //Extension method is a member of a static class whose
    //first parameter is declared with 'this' keyword.
    //Such a method can be called as an instance method
    //of its first parameter type by using namespace of
    //the static class in which it is defined.
    public static void FreezeAccount(this Account acc)
    {
        acc.Id = -acc.Id;
    }
}
