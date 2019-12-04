using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        float sum = 0;
        bool stipuhuprofukal = false;
        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (m == 3)
                stipuhuprofukal = true;
            else
                sum += m;
        }
        if (!stipuhuprofukal)
            if (sum / n == 5)
                Console.WriteLine("Named");
            else if (sum / n >= 4.5)
                Console.WriteLine("High");
            else
                Console.WriteLine("Common");
        else
            Console.WriteLine("None");
    }
}
