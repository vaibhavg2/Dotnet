
record Item(string Name, string Brand);

readonly record struct Customer(string Id, double Purchase, int Rating, string City = "Mumbai");

class Shop
{
	public static Item CreateItem(string name)
	{
		return new Item(name, "intel");
	}

	public static Customer CreateCustomer(string name)
	{
		return new Customer(name, 10000, 5);
	}
    
}
