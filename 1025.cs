using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine().Split();
        int[] g = new int[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = int.Parse(s[i]);
        }
        Array.Sort(g);
        int sum = 0;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            sum += g[i] / 2 + 1;
        }
        Console.WriteLine(sum);
    }
}
