﻿using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//Write a number to 30
        Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
        for (int i = 1; i < ((n - 2) + 1) / 2; i++)
        {
            Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
            Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
        }
        Console.WriteLine("{0}@", new string(' ', n - 1));
        Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
        for (int i = 1; i < ((n - 2) + 1) / 2; i++)
        {
            Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
            Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
        }
    }

}
