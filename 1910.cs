using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine().Split();
        int sum = 0;
        int index = 0;
        for (int i = 1; i < n - 1; i++)
        {
            int cs = int.Parse(s[i - 1]) + int.Parse(s[i]) + int.Parse(s[i + 1]);
            if (cs > sum)
            {
                sum = cs;
                index = i+1;
            }
        }
        Console.WriteLine("{0} {1}", sum, index);
    }
}
