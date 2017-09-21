using System;

class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = first; i <= second; i++)
        {
            for (int j = first; j <= second; j++)
            {
                if (count == max)
                {
                    break;
                }
                Console.Write("<{0}-{1}>", i, j);
                count++;
            }
        }
    }
}
