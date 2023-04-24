using System;

class Program 
{
	private static void Adjust(ref Investment target)
	{
		target.AllowRisk(target.Sum() < 500000);
	}

	public static void Main(string[] args)
	{
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		Investment inv = new Investment(p, n);
		Console.WriteLine("Future value of no-risk investment: {0:0.00}", inv.FutureValue());
		inv.AllowRisk(true);
		Console.WriteLine("Future value of low-risk investment: {0:0.00}", inv.FutureValue());
		Adjust(ref inv);
		Console.WriteLine("Future value of smart investment: {0:0.00}", inv.FutureValue());
	}
}
