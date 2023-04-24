IList<Interval> store = new List<Interval>();
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
    int i = int.Parse(args[0]) - 1;
    Console.WriteLine(store[i]);
}

