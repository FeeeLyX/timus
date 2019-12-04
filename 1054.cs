using System;

class Program
{
    static void step(ref Int64 num, int[] D, int n, int from, int to, int buffer)
    {
        if (D[n-1] == buffer) 
        {
            num = -1;
            return;
        }

        if (D[n-1] == from)
        {
            if (n == 1)
                return;
            int i = n-1;
            while ((D[i - 1] == from))
            {
                i--;
                if (i == 0)
                    break;
            }
            if (i != 0)
            {
                if((((n-i)%2==0)&&(D[i-1]==buffer))||(((n-i)%2!=0)&&(D[i-1]==to)))
                {
                    num = -1;
                    return;
                }
                num += (Int64)Math.Pow(2, i - 1);
                if ((n - i) % 2 == 0)
                    step(ref num, D, i - 1, buffer, to, from);
                else
                    step(ref num, D, i - 1, to, buffer, from);
            }
        }
        else
        {
            num += (Int64)Math.Pow(2, n - 1);
            if(n>1)
                step(ref num, D, n - 1, buffer, to, from);
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] D = new int[n];
        for (int i = 0; i < n; i++)
            D[i] = int.Parse(Console.ReadLine());
        Int64 num = 0;
        step(ref num, D, n, 1, 2, 3);
        Console.WriteLine(num);
    }
}
