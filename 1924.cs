using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine((int.Parse(Console.ReadLine()) + 1) % 4 < 2 ? "black" : "grimy");
    }
}
