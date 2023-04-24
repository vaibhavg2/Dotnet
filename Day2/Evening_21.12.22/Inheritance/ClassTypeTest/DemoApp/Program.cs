using Payroll;

//C# supports top-level statements which are copied by the
//compiler into Main method of auto-generated Program class
int n = int.Parse(args[0]);
float e = float.Parse(args[1]);
Employee jack = new Employee();
jack.Hours = n;
jack.HourlyRate = e;
Console.WriteLine("Jack's Income is {0:0.00}, Tax is {1:0.00} and Bonus is {2:0.00}", jack.Income(), Tax(jack), Bonus(jack));
SalesPerson jill = new SalesPerson(n, e, 350 * n);
Console.WriteLine("Jill's Income is {0:0.00}, Tax is {1:0.00} and Bonus is {2:0.00}", jill.Income(), Tax(jill), Bonus(jill));
Adjust(jack);
Console.WriteLine("Jack's future income will be: {0:0.00}", jack.Income());
Adjust(null);

//local function (it cannot be overloaded)
double Tax(Employee emp)
{
    double i = emp.Income(); //dynamic binding
    return i > 10000 ? 0.15 * (i - 10000) : 0;
}

double Bonus(Employee emp)
{
    if(emp is SalesPerson)
        return 0;
    return 0.12 * emp.Income();
}

void Adjust(Employee? emp)
{
    if(emp != null)
        emp.HourlyRate *= emp.Hours >= 175 ? 1.1f : 0.95f; 
}
