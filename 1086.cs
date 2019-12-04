using System;

namespace flx3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] prst = new int[15000];
            prst[0] = 2;
            int n = 1;
            for (int i = 3; i <= 163841; i++)
            {
                bool pr = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        pr = false;
                        break;
                    }
                }
                if (pr)
                {
                    prst[n] = i;
                    n++;
                }
            }
            int[] nums = new int[k];
            for(int i=0; i<k; i++) nums[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<k;i++) Console.WriteLine(prst[nums[i]-1]);
        }
    }
}
