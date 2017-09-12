using System;
//Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


class BankAccountData

{
    static void Main()
    {
        string name = "Georgi Ivanov Stefanov";

        decimal balance = 1250;
        string bankName = "First Invesment Bank";
        string iban = "BGFINV80425987";
        string creditCard1 = "3598246289";
        string creditCard2 = "2782567346";
        string creditCard3 = "6563863657";

        Console.WriteLine("Bank account data:");
        Console.WriteLine();
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Available amount of money (balance): {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit card numbers:");
        Console.WriteLine("Credit card 1: {0}; card 2: {1}; card3: {2}", creditCard1, creditCard2, creditCard3);


    }
}

