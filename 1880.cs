using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] nums = new int[1][];
        Array.Resize<int[]>(ref nums, 3);
        int nmin = 4000;
        int imin = 0;
        for (int i = 0; i < 3; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n<nmin)
            {
                nmin = n;
                imin = i;
            }
            Array.Resize<int>(ref nums[i], n);
            var s = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                nums[i][j] = int.Parse(s[j]);
            }
        }
        int res = 0;
        foreach (int num in nums[imin])
            if ((Array.Find<int>(nums[(imin + 1) % 3], i => i == num) != 0) && (Array.Find<int>(nums[(imin + 2) % 3], j => j == num) != 0))
                res++;
        Console.WriteLine(res);
    }
}
