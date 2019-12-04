using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().Split();
        int [] frame = new int[10];
        int minscore = 0;
        for (int i = 0; i < 10; i++)
        {
            frame[i] = int.Parse(s[i]);
            minscore += frame[i];
        }
        int maxscore = minscore;
        for (int i = 0; i < 7; i++)
            if (frame[i] == 10)
            {
                maxscore += frame[i + 1];
                if (frame[i + 1] == 10)
                    maxscore += frame[i + 2];
            }
        if(frame[7]==10)
        {
            maxscore += frame[8];
            if (frame[8] == 10)
                if (frame[9] <= 10)
                    maxscore += frame[9];
                else
                    maxscore += 10;
        }
        if (frame[8] == 10)
            if (frame[9] <= 20)
                maxscore += frame[9];
            else
            {
                minscore += 10;
                maxscore += 20;
            }
        Console.Write("{0} {1}", minscore, maxscore);
    }
}
