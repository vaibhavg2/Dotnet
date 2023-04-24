static class Server
{
    public static void Run()
    {
        byte[] buffer = new byte[80];
        using var client = new NamedPipeServerStream("enc");
        for(;;)
        {
            client.WaitForConnection();
            int n = client.Read(buffer);
            Transformer.Encrypt(buffer, n);
            client.Write(buffer[0 .. n]);
            client.Disconnect();
        }
    }
}