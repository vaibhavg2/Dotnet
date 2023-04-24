// using System.IO;
// using System.Text;

// namespace DemoFileIO
// {
//     // class Program
//     // {   
//         // Checking file exists or not.

//         // public static void Main(String[]args)
//         // {
//         //     string path = @"C:\Users\LEGION\OneDrive\Desktop\Assignments.txt";
//         //     if(File.Exists(path))
//         //         Console.WriteLine("File exeists.");
//         //     else
//         //         Console.WriteLine("File Not Found.");
//         // }

//         //Reading texts from a file

//         // public static void Main()
//         // {
//         //     string path = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText.txt";
//         //     if(File.Exists(path))
//         //     {   
//         //         Console.WriteLine("File Found.");
//         //         string data = File.ReadAllText(path);
//         //         Console.WriteLine(data);
//         //     }
//         //     else
//         //     {
//         //         Console.WriteLine("File not found.");
//         //     }
//         // }

//         //Copying a data from one file to another file.

//         // public static void Main()
//         // {   
//         //     string path1 = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText.txt";
//         //     string path2 = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText2.txt";
//         //     File.Copy(path1,path2,true);   //source file, destination file, overwrite(yes/no)
//         //     Console.WriteLine("File Copied.");
//         // }

//         //Creating a File

//         // public static void Main()
//         // {
//         //     string path = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText3.txt";
//         //     FileStream fs = new FileStream(path, FileMode.Create);
//         //     fs.Close();
//         //     Console.WriteLine("File has been created.");
//         // }


//        // Opening file and writing into it.
//         // static void Main(string[] args)
//         // {
//         //     string FilePath = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText3.txt";
//         //     FileStream fileStream = new FileStream(FilePath, FileMode.Append);
//         //     byte[] bdata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language.");
//         //     fileStream.Write(bdata, 0, bdata.Length);
//         //     fileStream.Close();
//         //     Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language.");
//         // }

//         //Reading using filestream class
//         // static void Main(string[] args)
//         // {
//         //     string FilePath = @"D:\DAC\Hussain sir's Dotnet\Self\DemoText3.txt";
//         //     string data;
//         //     FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
//         //     using (StreamReader streamReader = new StreamReader(fileStream))
//         //     {
//         //         data = streamReader.ReadToEnd();
//         //     }
//         //     Console.WriteLine(data);
//         // }
//     }
// }