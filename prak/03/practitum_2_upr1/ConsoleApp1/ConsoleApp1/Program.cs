using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\nastu\Desktop\info.ini");
            StreamWriter sw = new StreamWriter(@"C:\Users\nastu\Desktop\info.txt", false, Encoding.UTF7);
            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}
