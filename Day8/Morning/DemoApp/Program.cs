if(args[0] == "squares")
{
    double[] list = args.Skip(1).Select(double.Parse).ToArray();
    Console.WriteLine("Sum of Squares = {0}", Computation.Compute(list));
}
else if(args[0] == "box")
{
    double a = double.Parse(args[1]);
    double b = double.Parse(args[2]);
    double c = double.Parse(args[3]);
    float t = float.Parse(args[4]);
    var box = new LegacyBox(a, b, c, t);
    Console.WriteLine("Volume of Box = {0:0.00}", box.GetInnerVolume());
}