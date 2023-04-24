namespace Payroll
{
    //SalesPerson is a derived class of Employee (base class),
    //it inherits all the members of Employee
    class SalesPerson : Employee
    {
        //automatic property
        public double Sales { get; set; }

        public SalesPerson(int h, float r, double s) : base(h, r)
        {   
            Sales = s;
        }

        //overriding base class method
        public override double Income()
        {
            double amount = base.Income();
            if(Sales >= 25000)
                amount += 0.05 * Sales;
            return amount;
        }
    }
}