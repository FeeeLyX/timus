using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int steps = 0;
        int pos = 0;
        for (int i = 0; i < n; i++)
        {
            char l = Console.ReadLine()[0];
            int newpos = 0;
            switch (l)
            {
                case 'A':
                case 'P':
                case 'O':
                case 'R':
                    newpos = 0;
                    break;
                case 'B':
                case 'M':
                case 'S':
                    newpos = 1;
                    break;
                case 'D':
                case 'G':
                case 'J':
                case 'K':
                case 'T':
                case 'W':
                    newpos = 2;
                    break;

            }
            steps += Math.Abs(newpos - pos);
            pos = newpos;
        }
        Console.WriteLine(steps);
    }
}
