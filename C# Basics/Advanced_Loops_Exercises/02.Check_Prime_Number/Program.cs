using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = true;

        if (n < 2)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}