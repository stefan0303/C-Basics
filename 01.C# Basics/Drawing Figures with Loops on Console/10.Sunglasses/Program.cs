using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //Write a number to 10
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
        for (int i = 1; i < n - i - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));
        for (int i = 1; i < n - i - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

    }
}