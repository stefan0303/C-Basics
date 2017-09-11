using System;

//n/2-1

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(@"\{0}/",new string ('*',n-2));
            for (int row = 0; row < n/2-2; row++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",new string ('.',row+1),new string('*',n-4-row*2));
            }
            Console.WriteLine(@"{0}\/{0}",new string('.',n/2-1));
            if (n >= 12)
            {
                for (int row = 0; row < n / 2 - 2; row++)
                {
                    Console.WriteLine("{0}||{0}",new string('.',n/2-1));
                }
                Console.WriteLine("{0}", new string('-', n));
                Console.WriteLine("{0}", new string('-', n));
            }
            else
            {
                for (int rows = 0; rows < n / 2 - 1; rows++)
                { 
                    Console.WriteLine("{0}||{0}",new string('.',n/2-1));
                }
                Console.WriteLine("{0}", new string('-', n));
            }
            
        }
    }

