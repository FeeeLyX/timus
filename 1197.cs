using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine();
            int x = s[0] - 96;
            int y = s[1] - 48;
            int num = 0;
            for(int j=0; j<8; j++)
            {
                if (x + dx[j] > 0 && x + dx[j] < 9 && y + dy[j] > 0 && y + dy[j] < 9)
                {
                    num++;
                }
            }
            Console.WriteLine(num);
        }
    }
}
