/*
    A record type is compiled by default into a class
    with read-only properties corresponding to positional
    parameters in the definition of that record along with
    (1) parameterized constructor for initializing those properties
    (2) overrides for ToString, GetHahCode and Equals methods
*/
record Item(string Name, string Brand);

//immutable value-type record
readonly record struct Customer(string Id, double Purchase, int Rating);

class Shop
{
	public Item[] GetItems() {
		return new Item[]{
			new Item("cpu", "intel"),
			new Item("ssd", "samsung"),
			new Item("mouse", "logitech"),
			new Item("motherboard", "intel"),
			new Item("cpu", "amd"),
			new Item("ddr", "samsung"),
			new Item("ssd", "seagate"),
			new Item("keyboard", "logitech"),
			new Item("monitor", "samsung")
		};
	}

    public ICollection<Customer> GetCustomers()
    {
		var customers = new List<Customer>();
		customers.Add(new Customer("Madhuri", 35000, 3));
		customers.Add(new Customer("Gaurav", 58000, 4));
		customers.Add(new Customer("Vaibhav", 12000, 2));
		customers.Add(new Customer("Anshika", 67000, 5));
		customers.Add(new Customer("Shubham", 44000, 3));
		customers.Add(new Customer("Divyani", 84000, 4));
		customers.Add(new Customer("Jinisha", 45000, 2));
		customers.Add(new Customer("Priyal", 19000, 1));
		customers.Add(new Customer("Raviraj", 95000, 5));
		customers.Add(new Customer("Yash", 29000, 3));
		return customers;
      
    }
}
