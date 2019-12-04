using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        var s = Console.ReadLine().Split();
        a = int.Parse(s[0]);
        b = int.Parse(s[1]);
        c = a + b;
        Console.WriteLine(c);
    }
}
