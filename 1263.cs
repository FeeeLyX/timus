using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[] votes = new int[N];
        for (int i = 0; i < M; i++)
        {
            votes[int.Parse(Console.ReadLine()) - 1]++;
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("{0:f2}%", (double)(votes[i] * 100) / M);
        }
    }
}
