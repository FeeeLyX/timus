using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dims = new int[3];
        var s = Console.ReadLine().Split();
        for (int i = 0; i < 3; i++)
            dims[i] = int.Parse(s[i]);

        string cmd = Console.ReadLine();

        int u = dims[1];
        int d = 1;
        int l = dims[0];
        int r = 1;
        int f = dims[2];
        int b = 1;

        if (cmd != null)
            for (int i = 0; i < cmd.Length; i++)
                switch (cmd[i])
                {
                    case 'u':
                        if (u < dims[1])
                            u++;
                        if (d < dims[1])
                            d++;
                        break;
                    case 'd':
                        if (u > 1)
                            u--;
                        if (d > 1)
                            d--;
                        break;
                    case 'l':
                        if (l < dims[0])
                            l++;
                        if (r < dims[0])
                            r++;
                        break;
                    case 'r':
                        if (l > 1)
                            l--;
                        if (r > 1)
                            r--;
                        break;
                    case 'f':
                        if (f < dims[2])
                            f++;
                        if (b < dims[2])
                            b++;
                        break;
                    case 'b':
                        if (f > 1)
                            f--;
                        if (b > 1)
                            b--;
                        break;
                }

        dims[0] = Math.Abs(l - r) + 1;
        dims[1] = Math.Abs(u - d) + 1;
        dims[2] = Math.Abs(f - b) + 1;

        Console.WriteLine((Int64)dims[0] * (Int64)dims[1] * (Int64)dims[2]);
    }
}
