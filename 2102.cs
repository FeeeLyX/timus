using System;

class Program
{
    static void Main(string[] args)
    {
        Int64 n = Int64.Parse(Console.ReadLine());
        int power = 0;
        for (Int64 i = 2; i * i <= n; i++)
        {
            if (Math.Pow(i, 20 - power) > n)
                break;
            bool isprime = true;
            if (n % i == 0)
            {
                for (Int64 j = 2; j * j <= i; j++)
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                if (isprime)
                    while (n % i == 0)
                    {
                        n = n / i;
                        power++;
                    }
                if (power > 20)
                    break;
            }
        }
        if (n != 1)
            power++;
        if (power != 20)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
    }
}
