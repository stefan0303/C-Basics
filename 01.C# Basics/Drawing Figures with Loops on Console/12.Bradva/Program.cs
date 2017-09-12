using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', n * 3) + "**" + new string('-', (n * 5) - (n * 3) - 2));

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine((new string('-', n * 3) + "*{0}*" + new string('-', (n * 5) - (n * 3) - 2 - i)), new string('-', i));
        }
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine(new string('*', n * 3 + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
        }
        int m = 0;
        for (int i = 1; i <= n / 2 - 1; i++)
        {

            Console.WriteLine(new string('-', n * 3 - i + 1) + "*" + new string('-', n + i - 2 + m) + "*" + new string('-', n - i));

            m++;
            if (i == n / 2 - 1)
            {
                Console.WriteLine(new string('-', n * 3 - i) + new string('*', n + i + m + 1) + new string('-', n - i - 1));
            }
        }


    }
}

