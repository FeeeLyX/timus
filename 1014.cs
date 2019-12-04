using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(10);
            return;
        }
        if (n < 10)
        {
            Console.WriteLine(n);
            return;
        }
        int[] nums = new int[8];
        for (int i = 9; i > 1; i--)
        {
            while (n % i == 0)
            {
                n = n / i;
                nums[i - 2]++;
            }
        }
        if (n != 1)
        {
            Console.WriteLine(-1);
            return;
        }
        else
        {
            for(int i=0; i<8; i++)
            {
                for (int j = 0; j < nums[i]; j++)
                    Console.Write(i+2);
            }
        }
    }
}
