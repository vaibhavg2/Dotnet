if(args.Length > 1)
{
    int sz = args.Length > 2 ? int.Parse(args[2]) : 80;
    Span<byte> buffer = sz > 128 ? new byte[sz] : stackalloc byte[sz];
    using var input = new FileStream(args[0], FileMode.Open);
    using var output = new FileStream(args[1], FileMode.CreateNew);
    while(input.Position < input.Length)
    {
        int n = input.Read(buffer);
        Transformer.Encrypt(buffer, n);
        output.Write(buffer[0 .. n]);
    }
}