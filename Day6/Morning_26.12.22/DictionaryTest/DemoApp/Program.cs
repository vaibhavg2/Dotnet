//IDictionary<string, Interval> store = new Dictionary<string, Interval>();
//IDictionary<string, Interval> store = new SortedList<string, Interval>();
IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
store.Add("monday", new Interval(4, 31));
store.Add("tuesday", new Interval(6, 12));
store.Add("wednesday", new Interval(5, 53));
store.Add("thursday", new Interval(7, 24));
store.Add("friday", new Interval(3, 45));
//store.Add("monday", new Interval(2, 21));
store["monday"] = new Interval(2, 21);
if(args.Length == 0)
{
    foreach(var pair in store)
        Console.WriteLine("{0, -12}{1, 8}", pair.Key, pair.Value);
}
else
{
    string k = args[0].ToLower();
    if(store.TryGetValue(k, out var v))
        Console.WriteLine(v);
}

