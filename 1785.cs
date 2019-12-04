using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            var s = Console.ReadLine();
            a = int.Parse(s);
            if ((a > 0) && (a < 5)) Console.WriteLine("few");
            else if (a < 10) Console.WriteLine("several");
            else if (a < 20) Console.WriteLine("pack");
            else if (a < 50) Console.WriteLine("lots");
            else if (a < 100) Console.WriteLine("horde");
            else if (a < 250) Console.WriteLine("throng");
            else if (a < 500) Console.WriteLine("swarm");
            else if (a < 1000) Console.WriteLine("zounds");
            else Console.WriteLine("legion");
        }
    }
}
