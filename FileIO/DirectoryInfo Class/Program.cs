using System.IO;

namespace DemoDirectory
{
    class Program
    {
        // public static void Main()
        // {   
        //     string path = @"E:\MyDirectory";
        //     DirectoryInfo dir = new DirectoryInfo(path);
        //     // dir.Create();
        //     dir.CreateSubdirectory("AnotherDirectory");
        //     Console.WriteLine("Directory Created.");
        // }

        // public static void Main()
        // {
        //     string path1 = @"E:\MyDirectory";
        //     string path2 = @"E:\MyDirectory2";
        //     DirectoryInfo dir = new DirectoryInfo(path1);
        //     dir.MoveTo(path2);
        //     Console.WriteLine("Directory Moved.");
        // }

        public static void Main()
        {
            string path = @"E:\MyDirectory2";
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
        }
    }
}