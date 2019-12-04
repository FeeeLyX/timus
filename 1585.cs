using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        int l = 0;
        int e = 0;
        for (int i = 0; i < n; i++)
            switch (Console.ReadLine()[0])
            {
                case 'E':
                    e++;
                    break;
                case 'L':
                    l++;
                    break;
                case 'M':
                    m++;
                    break;
            }
        if (e > m && e > l)
            Console.WriteLine("Emperor Penguin");
        else if (m > e && m > l)
            Console.WriteLine("Macaroni Penguin");
        else if (l > e && l > m)
            Console.WriteLine("Little Penguin");
    }
}
