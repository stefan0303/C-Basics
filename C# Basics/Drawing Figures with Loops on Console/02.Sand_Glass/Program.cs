using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());////Write a number to 50

        Console.WriteLine(new string('*', n));
        for (int row = 1; row < (n - 1) / 2; row++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', row), new string('*', n - row * 2));
        }

        for (int row = (n - 1) / 2; row >= 1; row--)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', row), new string('*', n - row * 2));
        }
        Console.WriteLine(new string('*', n));
    }
}