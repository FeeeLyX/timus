using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        table[n - 1, 0] = 1;
        table[0, n - 1] = n*n;
        for (int i = n - 2; i > -1; i--)
        {
            table[i, 0] = table[i + 1, 0] + (n - i - 1);
            for (int j = 1; j < n - i; j++)
            {
                table[i + j, j] = table[i + j - 1, j - 1] + 1;
            }
        }
        for (int i = 1; i < n - 1; i++)
        {
            table[i, n - 1] = table[i - 1, n - 1] - i;
            for(int j=1; j<i+1; j++)
            {
                table[i - j, n - j - 1] = table[i - j + 1, n - j] - 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("{0} ", table[j, i]);
            Console.WriteLine();
        }
    }
}
