using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        int num = int.Parse(s[0]);
        int cols = int.Parse(s[1]);
        s = Console.ReadLine().Split();
        int t = num % cols != 0 ? num / cols + 1 : num / cols;
        for(int i=0; i<t; i++)
        {
            int j = i;
            while(j<s.Length)
            {
                Console.Write(String.Format("{0,4}", int.Parse(s[j])));
                j += t;
            }
            Console.WriteLine();
        }
    }
}
