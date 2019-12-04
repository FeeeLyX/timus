using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        Console.WriteLine(int.Parse(s[0]) * (int.Parse(s[1]) + 1));
    }
}
