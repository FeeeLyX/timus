using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] table = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            var s = Console.ReadLine().Split();
            for (int j = 0; j < 5; j++)
            {
                table[i, j] = int.Parse(s[j]);
            }
        }
        int dist = table[0, 1] + table[1, 2] + table[2, 3] + table[3, 4];
        String seq = "1 2 3 4 5";
        int dist2 = table[0, 2] + table[2, 1] + table[1, 3] + table[3, 4];
        if (dist2 < dist)
        {
            dist = dist2;
            seq = "1 3 2 4 5";
        }
        dist2 = table[0, 3] + table[3, 2] + table[2, 1] + table[1, 4];
        if (dist2 < dist)
        {
            dist = dist2;
            seq = "1 4 3 2 5";
        }
        dist2 = table[0, 2] + table[2, 3] + table[3, 1] + table[1, 4];
        if (dist2 < dist)
        {
            dist = dist2;
            seq = "1 3 4 2 5";
        }
        Console.WriteLine(dist);
        Console.WriteLine(seq);
    }
}
