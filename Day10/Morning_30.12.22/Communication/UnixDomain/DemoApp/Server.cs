global using System.Net.Sockets;

static class Server
{
    public const string ServiceName = "encrypt.sock";

    public static void Run()
    {
        File.Delete(ServiceName);
        byte[] buffer = new byte[80];
        //Step 1
        var listener = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
        listener.Bind(new UnixDomainSocketEndPoint(ServiceName));
        listener.Listen();
        for(;;)
        {
            //Step 2
            var connection = listener.Accept();
            //Step 3
            int n = connection.Receive(buffer);
            Transformer.Encrypt(buffer, n);
            connection.Send(buffer[0 .. n]);
            //Step 4
            connection.Close();
        }
    }
}
