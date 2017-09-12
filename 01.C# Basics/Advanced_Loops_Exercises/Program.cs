using System;


class Program
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int m = 1; m <= n; m++)
            {
                for (var b = 'a'; b < 'a' + l; b++)
                {
                    for (var c = 'a'; c < 'a' + l; c++)
                    {
                        for (int d = Math.Max(i, m) + 1; d <= n; d++)
                        {
                            Console.Write("{0}{1}{2}{3}{4} ", i, m, b, c, d);
                        }

                    }

                }
            }
        }


    }
}

