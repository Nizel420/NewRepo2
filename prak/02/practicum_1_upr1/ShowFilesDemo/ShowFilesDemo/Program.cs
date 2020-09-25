using System.IO;
using System;
namespace ShowFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); ShowDirectory(dir);
        }

        static void ShowDirectory(DirectoryInfo dir)
        {
            // Показать все файлы
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    ShowDirectory(subDir);
                }
            }
        }
    }
}
