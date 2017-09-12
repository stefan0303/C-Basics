using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //•	N – цяло число–0 <= N < M
        int m = int.Parse(Console.ReadLine());//•	M –цяло число– N < M <= 10000
        int s = int.Parse(Console.ReadLine());//•	S – цяло числo – N <= S <= M

        for (int c = m; c >= n; c--)
        {
            if ((c % 2 == 0) && (c % 3 == 0))
            {
                if (c == s)
                {
                    break;

                }
                Console.Write(c + " ");
            }

        }
    }
}

