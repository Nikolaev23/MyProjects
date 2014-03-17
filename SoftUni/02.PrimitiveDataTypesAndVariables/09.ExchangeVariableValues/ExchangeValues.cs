//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.
using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Variable value A :");
        int firstValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Variable value B :");
        int secondValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Value A = {0} , Value B = {1}",firstValue,secondValue);
        int thirdValue = firstValue;
        firstValue = secondValue;
        secondValue = thirdValue;
        Console.WriteLine("Exchanged Value A = {0} , Value B = {1}",firstValue,secondValue);
    }
}

