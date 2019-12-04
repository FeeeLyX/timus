using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int g = n+2;
        for(int i=0; i<n; i++)
            if (Console.ReadLine().Contains("+one")) g++;
        if (g == 13) g++;
        Console.WriteLine(g*100);
    }
}
