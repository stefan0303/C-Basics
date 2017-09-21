using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //Write a number to 10
        int inside1 = n - 2;
        int inside = 5;

        Console.WriteLine(@"\{0}|{0}/", new string('-', n));
        for (int row = 1; row < (n - 1) / 2; row++)
        {
            Console.WriteLine(@"{0}\{1}|{1}/{0}", new string('-', row * 2), new string('-', inside1));
            inside1 = inside1 - 2;
        }
        Console.WriteLine("{0}#.#{0}", new string('-', n));
        for (int row = 1; row < (n + 1) / 2; row++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', n - row * 2), new string('.', inside));
            inside = inside + 4;
        }
        Console.WriteLine("#{0}#", new string('.', n * 2 + 1));
        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', row), new string('.', n * 2 - row * 2 + 1));

        }
    }
}
