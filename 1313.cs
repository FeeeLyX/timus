using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine().Split();
            for (int j = 0; j < n; j++) matrix[i, j] = int.Parse(s[j]);
        }
        for(int i=0; i<n; i++) 
            for(int j=0; j<i+1; j++) 
                Console.Write("{0} ", matrix[i - j, j]);
        for (int j=1; j<n; j++)
            for (int i=0; i<n-j; i++)
                Console.Write("{0} ", matrix[n-i-1, j+i]);
    }
}
