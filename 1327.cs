using System;

class Program
{
    static void Main(string[] args)
    {
        int f = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        f = (f % 2 == 1) ? f - 1 : f;
        s = (s % 2 == 1) ? s + 1 : s;
        Console.WriteLine((s - f) / 2);
    }
}
