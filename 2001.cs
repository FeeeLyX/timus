using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().Split();
            int a = int.Parse(s1[0]);
            int b = int.Parse(s1[1]);
            var s2 = Console.ReadLine().Split();
            b -= int.Parse(s2[1]);
            var s3 = Console.ReadLine().Split();
            a -= int.Parse(s3[0]);
            Console.WriteLine("{0:D} {1:D}",a,b);
        }
    }
}
