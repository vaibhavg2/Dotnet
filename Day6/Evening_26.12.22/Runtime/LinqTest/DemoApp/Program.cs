var shop = new Shop();
if(args[0] == "items")
{
    shop.GetItems()
        .Capitalize()
        .PrintEach();
}