class Employee
{   
    int id;
    string name, designation, place;
    public Employee(int id, string name, string designation, string place)
    {
        this.id = id;
        this.name = name;
        this.designation = designation;
        this.place = place;
    }

    public object this[int n]
    {

        get
        {
            if(n==1)
                return id;
            else if(n==2)
                return name;
            else if(n==3)
                return designation;
            else if(n==4)
                return place;
            else
                return null;
        }

        set
        {
            if(n==1)
                this.name = (string) value; // 
        }
    }

    public object this[string s]        //indexer overloading
    {
        get
        {
            if(s==name)
                return designation;
            else
                return null;
        }
    }

}