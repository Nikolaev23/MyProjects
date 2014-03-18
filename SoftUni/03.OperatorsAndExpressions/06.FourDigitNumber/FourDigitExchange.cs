/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs */
using System;

class FourDigitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter four digits number : (abcd) format");
        string number = Console.ReadLine();
        while (number.Length < 4 || number.Length > 4)
        {
            Console.WriteLine("Enter correct four digits number : (abcd) format");
            number = Console.ReadLine();
        }
        int currentNumber = 0;
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            currentNumber = int.Parse(number[i].ToString());
            sum += currentNumber;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of numbers {0} is {1}",number,sum);
        Console.WriteLine(new string('-',30));

        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);  
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));

        int firstDigit = int.Parse(number[0].ToString());
        int secondDigit = int.Parse(number[1].ToString());
        int thirdDigit = int.Parse(number[2].ToString());
        int fourthDigit = int.Parse(number[3].ToString());

        Console.WriteLine("The result is: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        Console.WriteLine(new string('-',30));
        Console.WriteLine("The result is: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine(new string('-', 30));


    }
}

