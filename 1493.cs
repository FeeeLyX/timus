using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int lastnum = input %10;
        int sum2 = 0;
        for(int i=0; i<3; i++)
        {
            sum2 += input % 10;
            input = input / 10;
        }
        int sum1 = 0;
        for(int i=0; i<3; i++)
        {
            sum1 += input % 10;
            input = input / 10;
        }
        if ((sum1 > sum2) && (lastnum == 9))
            Console.WriteLine("No");
        else if ((sum1 < sum2) && (lastnum == 0))
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
    }
}
