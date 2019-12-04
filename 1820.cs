using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        if (int.Parse(s[0]) < int.Parse(s[1])) Console.WriteLine(2);
        else Console.WriteLine(Math.Ceiling(decimal.Parse(s[0]) * 2 / decimal.Parse(s[1])));
    }
}
