using System;

    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            long p = long.Parse(s[1]);
            while ((n != 0) && (p != 0))
            {
                if (p <= n)
                    Console.WriteLine(0);
                else
                {
                    long result = 1;
                    for (int i = 1; i <= n; i++)
                        result = (result * i) % p;
                    Console.WriteLine(result);
                }
                s = Console.ReadLine().Split();
                n = int.Parse(s[0]);
                p = int.Parse(s[1]);
            }
        }
    }
