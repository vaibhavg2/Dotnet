var shop = new Shop();
if(args[0] == "items")
{
    shop.GetItems()
        .Where(i => i.Brand == args[1])
        // .Select(i => i.Name)
        .Capitalize()
        .PrintEach();
}
else if(args[0] == "customers")
{
    double min = double.Parse(args[1]);
    var selection = from c in shop.GetCustomers()
                    where c.Purchase >= min
                    orderby c.Id
                    select new 
                    {
                        Email = c.Id.ToLower() + "@cititek.com",
                        Stars = new string('*', c.Rating)
                    };
    foreach(var entry in selection)
        Console.WriteLine($"{entry.Email}\t{entry.Stars}");
}