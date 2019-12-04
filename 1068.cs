using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while(i!=a)
            {
                sum += i;
                i += Math.Sign(a-1);
            }
            sum += a;
            Console.WriteLine(sum);
        }
    }
}
