using System; 

class Program 
{ 

    static void Main() 
    {
        int g,l; 
        var s = Console.ReadLine().Split();
        g = int.Parse(s[0]); 
        l = int.Parse(s[1]);
        Console.Write(l-1);
        Console.Write(" ");
        Console.WriteLine(g-1);
    }
}
