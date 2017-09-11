using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//Write a number
        string firstLine = "/" + new string('^', n / 2) + "\\" + "/" + new string('^', n / 2) + "\\";
        int diference = 2 * n - firstLine.Length;
        Console.WriteLine("/" + new string('^', n / 2) + "\\" + new string('_', diference) + "/" + new string('^', n / 2) + "\\");
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
        }
        Console.WriteLine("|{0}{1}{0}|", new string(' ', (n * 2 - diference - 2) / 2), new string('_', diference));
        Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', diference) + "\\" + new string('_', n / 2) + "/");
    }
}


