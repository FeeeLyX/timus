using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (45 * (12 - a) <= 60 * 4) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
