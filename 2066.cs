using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[3];
        for (int i = 0; i < 3; i++)
            a[i] = int.Parse(Console.ReadLine());
        if(a[1]<2)
            Console.WriteLine(a[0]-a[1]-a[2]);
        else
            Console.WriteLine(a[0] - a[1] * a[2]);
    }
}
