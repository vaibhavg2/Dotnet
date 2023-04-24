//ISet<Interval> store = new HashSet<Interval>();
//ISet<Interval> store = new SortedSet<Interval>();
ISet<Interval> store = new SortedSet<Interval>(new IntervalComparison());
store.Add(new Interval(4, 31));
store.Add(new Interval(6, 12));
store.Add(new Interval(5, 53));
store.Add(new Interval(7, 24));
store.Add(new Interval(3, 45));
store.Add(new Interval(2, 105));
if(args.Length == 0)
{
    foreach(var item in store)
        Console.WriteLine(item);
}
else
{
    int s = int.Parse(args[0]);
    Interval i = new Interval(0, s);
    if(store.Contains(i))
        Console.WriteLine("Found the Interval!");
}

class IntervalComparison : IComparer<Interval>
{
    public int Compare(Interval x, Interval y)
    {
        return x.Seconds - y.Seconds;
    }
}