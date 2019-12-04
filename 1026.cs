using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
            nums[i] = int.Parse(Console.ReadLine());
        Console.ReadLine();
        Array.Sort(nums);
        n = int.Parse(Console.ReadLine());
        int[] indexes = new int[n];
        for (int i = 0; i < n; i++)
            indexes[i] = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            Console.WriteLine(nums[indexes[i]-1]);
    }
}
