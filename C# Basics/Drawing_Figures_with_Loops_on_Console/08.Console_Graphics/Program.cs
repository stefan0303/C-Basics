using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//Write an even number number to 21
        Console.WriteLine(new string('*', (n * 2)));
        Console.WriteLine(new string('*', (n * 2)));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string(' ', n - 1));

        }
        Console.WriteLine(new string('~', n * 2));
        Console.WriteLine(new string('~', n * 2));
    }
}