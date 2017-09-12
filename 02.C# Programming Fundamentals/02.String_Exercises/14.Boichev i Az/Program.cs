using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] splitter=new char[]{' ','\t'};
            string[] sentence = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double result = 0;


            for (int i = 0; i < sentence.Length; i++)
            {
                string currentFrace = sentence[i];
                char first = currentFrace[0];
                char last = currentFrace[currentFrace.Length - 1];
                double number = Convert.ToDouble(currentFrace.Substring(1, currentFrace.Length - 2));

                int multiplyer = first % 32;
                if (char.IsLower(first))
                {
                    number *= multiplyer;
                }
                else
                {
                    number /= multiplyer;
                }
                int lastAsNumber = last % 32;
                if (char.IsLower(last))
                {
                    number += lastAsNumber;
                }
                else
                {
                    number -= lastAsNumber;
                }
                result += number;
            }
            Console.WriteLine("{0:f2}", result);



        }
    }
}
