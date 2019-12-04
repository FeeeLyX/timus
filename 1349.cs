using System;

class Program
{
  static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    switch(n)
    {
      case 1:
        Console.WriteLine("1 2 3");
        break;
      case 2:
        Console.WriteLine("3 4 5");
        break;
      default:
        Console.WriteLine("-1");
        break;
    }
  }
}
