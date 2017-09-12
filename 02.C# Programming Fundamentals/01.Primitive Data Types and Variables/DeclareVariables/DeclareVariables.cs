using System;

class DeclareVariables
//    Problem 1. Declare Variables

    //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.
{
    static void Main()
    {
        sbyte count = -115;
        uint money = 52130;
        ulong number = 4825932;
        byte friends = 97;
        int number2 = -10000;
      
        Console.WriteLine("{0},{1},{2},{3},{4}", count, money, number, friends, number2);
    }



}

