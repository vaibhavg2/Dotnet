using System.Text;

static class Client
{
    public static void Run(string text)
    {
        using var server = new NamedPipeClientStream("enc");
        server.Connect();
        server.Write(Encoding.UTF8.GetBytes(text));
        byte[] buffer = new byte[80];
        int n = server.Read(buffer);
        Console.WriteLine(Encoding.UTF8.GetString(buffer[0 .. n]));
    }
}
