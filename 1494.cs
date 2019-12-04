using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] rev = new int [n];
        int last = 0;
        bool cheater = false;
        Stack<int> chich = new Stack<int>();
        for(int i=0; i<n; i++)
        {
            rev[i] = int.Parse(Console.ReadLine());
            for(int j=last; j<rev[i]; j++)
            {
                chich.Push(j+1);
                last = rev[i];
            }
            if (chich.Peek() == rev[i])
                chich.Pop();
            else
                cheater = true;
        }
        if (cheater)
            Console.WriteLine("Cheater");
        else
            Console.WriteLine("Not a proof");
    }
}
