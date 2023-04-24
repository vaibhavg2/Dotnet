using System.Text;

static class Client
{
    public static void Run(string text)
    {
        //Step 1
        var connection = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
        connection.Connect(new UnixDomainSocketEndPoint(Server.ServiceName));
        //Step 2
        connection.Send(Encoding.UTF8.GetBytes(text));
        byte[] buffer = new byte[80];
        int n = connection.Receive(buffer);
        Console.WriteLine(Encoding.UTF8.GetString(buffer[0 .. n]));
        //Step 3
        connection.Close();
    }
}