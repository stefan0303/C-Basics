using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//Write a number to 10
        Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));
        {
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', n - row), new string('_', n * 2 - 1 + 2 * row));
            }
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', (n * 4 + 3 - 9) / 2));
            Console.WriteLine(@"\\{0}//", new string('_', (n * 4 + 3 - 4)));
            for (int row = 1; row < n; row++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', row), new string('_', (n * 4 + 3 - 4 - row * 2)));
            }

        }
    }
}