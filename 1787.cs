using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine().Split();
        int k = int.Parse(s[0]);
        int n = int.Parse(s[1]);
        s = Console.ReadLine().Split();
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result += int.Parse(s[i]);
            result -= k;
            if (result < 0) result = 0;
        }
        Console.WriteLine("{0}", result);
    }
}
