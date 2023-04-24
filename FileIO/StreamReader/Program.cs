using System.IO;

namespace DemoStreamReader
{
    class Program
    {
        public static void Main()
        {
            string path = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using( StreamReader sr = new StreamReader(fs))
                {
                    // string line = sr.ReadLine();                //will read only the first line of the textfile.
                    // Console.WriteLine(line);

                    string line = "";
                    while((line = sr.ReadLine())!=null)         //will return the whole text present in the file.
                    {
                        Console.WriteLine(line);
                    }

                    // foreach(var ch in sr.ReadLine())                //Here character by character text will be printed.
                    //         Console.WriteLine(ch);
                }
            }

        }
    }
}