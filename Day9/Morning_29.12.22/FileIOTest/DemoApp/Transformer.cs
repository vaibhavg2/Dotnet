static class Transformer
{
   public static void Encrypt(Span<byte> data, int count)
    {
        for(int i = 0; i < count; ++i)
            data[i] = (byte)(data[i] ^ '#');
    }
}
