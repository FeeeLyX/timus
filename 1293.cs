using System; 

class Program 
{ 

    static void Main() 
    {
        int N,A,B; 
        var s = Console.ReadLine().Split();
        N = int.Parse(s[0]); 
        A = int.Parse(s[1]);
        B = int.Parse(s[2]);
        Console.WriteLine(2 * N * A * B);
    }
}
