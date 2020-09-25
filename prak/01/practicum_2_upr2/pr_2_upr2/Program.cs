using System;

namespace pr_2_upr2
{
  class Program
  {
    static void Main(string[] args)
    {

      string s = "Microsoft .NET Framework 2 Application Development Foundation";
      string[] sa = s.Split(" ");
      Array.Sort(sa);
      s = string.Join(" ", sa); Console.WriteLine(s);
    }
  }
}
