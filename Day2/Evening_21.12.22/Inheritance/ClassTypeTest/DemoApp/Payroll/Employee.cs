namespace Payroll
{
    class Employee
    {
        private int hours;
        private float rate;
 
        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
        }

        public Employee() : this(0, 40)
        {
        }

        //property is a member which provides methods to get or set
        //value of a private field using syntax similar to reading
        //or writing a public field
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public float HourlyRate
        {
            get { return rate; }
            set { rate = value; }
        }

        //only a method defined with 'virtual' modifier can be
        //overridden in the derived class and such a method is
        //invoked using dynamic binding
        public virtual double Income()
        {   
            double amount = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                amount += 50 * ot;
            return amount;
        }

    }
}