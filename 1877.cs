using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a % 2 == 0) || (b % 2 != 0)) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
