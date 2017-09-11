using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //Write a number to 15
            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*',n*3));
            for (int row = 0; row < n-1; row++)
            {
                Console.WriteLine("{0}*{1}{2}*{0}",new string('.',n-row-1),new string('.',n*3+row),new string('.',row));
            }
            Console.WriteLine(new string('*', n*5));
            for (int row = 2; row < n*2+2; row++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',row-1),new string('.',n*5-2*row));
            }
            Console.WriteLine("{0}{1}{0}",new string ('.',n*2+1),new string('*',n-2));
        }
    }

