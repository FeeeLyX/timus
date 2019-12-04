using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        int n = int.Parse(s[0]);
        int k = int.Parse(s[1]);
        s = Console.ReadLine().Split();
        int boom = 0;
        int droid = 0;
        for(int i=0; i<n; i++)
        {
            if(int.Parse(s[i])<k)
            {
                droid += k - int.Parse(s[i]);
            }
            else if(int.Parse(s[i])>k)
            {
                boom += int.Parse(s[i]) - k;
            }
        }
        Console.WriteLine("{0} {1}", boom, droid);
    }
}
