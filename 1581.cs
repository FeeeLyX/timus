using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> output = new List<int>();
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine().Split();
        int currentnumber = int.Parse(s[0]);
        int currentquantity = 1;
        for(int i=1; i<n; i++)
        {
            if(int.Parse(s[i])==currentnumber)
            {
                currentquantity++;
            }
            else
            {
                output.Add(currentquantity);
                output.Add(currentnumber);
                currentnumber = int.Parse(s[i]);
                currentquantity = 1;
            }
        }
        output.Add(currentquantity);
        output.Add(currentnumber);
        for (int i = 0; i < output.Count; i++)
            Console.Write("{0} ", output[i]);
    }
}
