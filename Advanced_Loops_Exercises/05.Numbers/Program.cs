using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int first = n / 100;
        int second = (n / 10) % 10;
        int third = n % 10;

        int row = first + second;
        int col = first + third;
        

        for (int m = 1; m <= row; m++)
        {
            if (n % 5 == 0)
            {

                n = n - first;
            }
            else if (n % 3 == 0)
            {

                n = n - second;
            }
            else
            {

                n = n + third;
            }
            Console.Write(n + " ");
            for (int p = 1; p < col; p++)
            {
                if (n % 5 == 0)
                {

                    n = n - first;
                }
                else if (n % 3 == 0)
                {

                    n = n - second;
                }
                else
                {

                    n = n + third;
                }
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }
    }
}

